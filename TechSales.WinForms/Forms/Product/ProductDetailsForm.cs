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
using TechSales.Domain.Enums;
using TechSales.Infrastructure.Entities;
using TechSales.Infrastructure.Persistence;

namespace TechSales.WinForms.Forms.Product
{
    public partial class ProductDetailsForm : Form
    {
        private readonly ProductService _productService;
        private readonly InventoryService _inventoryService;

        public ProductDetailsForm(TechSalesDbContext db, int productId)
        {
            InitializeComponent();
            _productService = new ProductService(db);
            _inventoryService = new InventoryService(db);

            LoadProduct(productId);
        }

        private int _productId;

        private void LoadProduct(int productId)
        {
            _productId = productId;

            var product =
                _productService.GetById(productId);

            if (product == null)
            {
                MessageBox.Show("Product not found");
                Close();
                return;
            }

            lblNameValue.Text = product.Name;
            lblPriceValue.Text = product.UnitPrice.ToString("C");

            lblCategoryValue.Text =
                product.Category.Name;

            lblSupplierValue.Text =
                product.Supplier.CompanyName;

            lblStockValue.Text =
                product.StockQuantity.ToString();

            lblStatusValue.Text =
                product.IsActive
                    ? "Active"
                    : "Inactive";
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (_productId <= 0)
                return;

            int qty = (int)numAddStock.Value;

            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0");
                return;
            }

            var dto = new AdjustInventoryDto
            {
                ProductId = _productId,
                QuantityChange = qty,
                TransactionType = (int)InventoryTransactionType.Purchase,
                ReferenceId = null
            };

            try
            {
                _inventoryService.AdjustStock(dto);

                MessageBox.Show("Stock updated!");

                // refresh UI
                LoadProduct(_productId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Delete this product?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            _productService.Delete(_productId);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
