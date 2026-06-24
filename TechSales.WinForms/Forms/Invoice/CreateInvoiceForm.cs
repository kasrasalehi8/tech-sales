using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSales.Application.DTO;
using TechSales.Application.Services;
using TechSales.Infrastructure.Persistence;

namespace TechSales.WinForms.Forms.Invoice
{
    public partial class CreateInvoiceForm : Form
    {
        private readonly TechSalesDbContext _db;

        private readonly CustomerService _customerService;
        private readonly ProductService _productService;
        private readonly InvoiceService _invoiceService;

        private readonly List<AddInvoiceItemDto> _items = new();

        public CreateInvoiceForm(TechSalesDbContext db)
        {
            InitializeComponent();

            dgvItems.ColumnHeadersDefaultCellStyle.SelectionBackColor =dgvItems.ColumnHeadersDefaultCellStyle.BackColor;
            dgvItems.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvItems.ColumnHeadersDefaultCellStyle.ForeColor;

            _db = db;

            _customerService =
                new CustomerService(db);

            _productService =
                new ProductService(db);

            _invoiceService =
                new InvoiceService(db);

            LoadCustomers();
            LoadProducts();
        }

        private void LoadCustomers()
        {
            cboCustomer.DataSource =
                _customerService.GetAll();

            cboCustomer.DisplayMember = "FullName";
            cboCustomer.ValueMember = "Id";
        }

        private void LoadProducts()
        {
            cboProduct.DataSource = _productService.GetAll()
                    .Where(p => p.IsActive && p.StockQuantity > 0)
                    .ToList();

            cboProduct.DisplayMember = "Name";

            cboProduct.ValueMember = "Id";

            cboProduct.SelectedIndex = -1;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cboProduct.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select a product.");

                return;
            }

            int productId =
                (int)cboProduct.SelectedValue;

            int quantity =
                (int)numQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show(
                    "Quantity must be greater than zero.");

                return;
            }

            var existingItem = _items.FirstOrDefault(i => i.ProductId == productId);

            var product = _productService.GetById(productId);

            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            int existingQuantity = existingItem?.Quantity ?? 0;

            if (existingQuantity + quantity > product.StockQuantity)
            {
                MessageBox.Show(
                    $"Only {product.StockQuantity} units are available.");

                return;
            }

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _items.Add(
                    new AddInvoiceItemDto
                    {
                        ProductId = productId,
                        Quantity = quantity
                    });
            }

            RefreshItemsGrid();
        }

        private void RefreshItemsGrid()
        {
            dgvItems.DataSource = null;
            dgvItems.Columns.Clear();

            dgvItems.DataSource =
                _items.Select(i =>
                {
                    var product = _productService.GetById(i.ProductId);

                    return new
                    {
                        ProductId = product.Id,
                        Product = product.Name,
                        Price = product.UnitPrice,
                        Quantity = i.Quantity,
                        Total = product.UnitPrice * i.Quantity
                    };
                })
                .ToList();

            dgvItems.Columns["ProductId"].Visible = false;
            dgvItems.Columns["Product"].HeaderText = "Product";
            dgvItems.Columns["Price"].HeaderText = "Unit Price";
            dgvItems.Columns["Quantity"].HeaderText = "Qty";
            dgvItems.Columns["Total"].HeaderText = "Line Total";
            dgvItems.Columns["Price"].DefaultCellStyle.Format = "$#,##0.00";
            dgvItems.Columns["Total"].DefaultCellStyle.Format = "$#,##0.00";

            UpdateTotal();
            numQuantity.Value = 1;
            cboProduct.SelectedIndex = -1;

            if (!dgvItems.Columns.Contains("Delete"))
            {
                var deleteColumn = new DataGridViewButtonColumn();

                deleteColumn.Name = "Delete";
                deleteColumn.HeaderText = "";
                deleteColumn.Text = "🗑";
                deleteColumn.UseColumnTextForButtonValue = true;
                deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                deleteColumn.Width = 30;

                dgvItems.Columns.Add(deleteColumn);
            }
        }

        private void UpdateTotal()
        {
            decimal total =
                _items.Sum(i =>
                {
                    var product =
                        _productService.GetById(i.ProductId);

                    return product.UnitPrice * i.Quantity;
                });

            lblTotalValue.Text = total.ToString("$#,##0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCustomer.SelectedValue == null)
                {
                    MessageBox.Show("Please select a customer.");

                    return;
                }

                if (!_items.Any())
                {
                    MessageBox.Show("Please add at least one item.");

                    return;
                }

                var dto =
                    new AddInvoiceDto
                    {
                        CustomerId = (int)cboCustomer.SelectedValue,
                        InvoiceDate = dtpInvoiceDate.Value,
                        Items = _items
                    };

                _invoiceService.Create(dto);

                MessageBox.Show("Invoice created successfully.");

                DialogResult =
                    DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvItems.Columns[e.ColumnIndex].Name != "Delete")
                return;

            int productId =
                (int)dgvItems.Rows[e.RowIndex]
                    .Cells["ProductId"]
                    .Value;

            var item = _items.FirstOrDefault(i => i.ProductId == productId);

            if (item != null)
            {
                var result = MessageBox.Show("Remove this item from the invoice?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _items.Remove(item);

                    RefreshItemsGrid();
                }
            }
        }

        private void dgvItems_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvItems.Columns[e.ColumnIndex].Name == "Delete")
            {
                Cursor = Cursors.Hand;
            }
        }

        private void dgvItems_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
