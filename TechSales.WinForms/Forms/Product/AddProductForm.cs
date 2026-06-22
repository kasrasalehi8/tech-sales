using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSales.Application.Services;
using TechSales.Application.DTO;
using TechSales.Infrastructure.Persistence;

namespace TechSales.WinForms.Forms.Product
{
    public partial class AddProductForm : Form
    {
        private readonly ProductService _productService;

        public AddProductForm(TechSalesDbContext db)
        {
            InitializeComponent();

            _productService = new ProductService(db);

            LoadCategories();
            LoadSuppliers();
        }

        private void LoadCategories()
        {
            cboCategory.DataSource =
                _productService.GetCategories();

            cboCategory.DisplayMember = "Name";

            cboCategory.ValueMember = "Id";
        }

        private void LoadSuppliers()
        {
            cboSupplier.DataSource =
                _productService.GetSuppliers();

            cboSupplier.DisplayMember = "CompanyName";

            cboSupplier.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new AddProductDto
                {
                    Name = txtName.Text,

                    CategoryId =
                        (int)cboCategory.SelectedValue,

                    SupplierId =
                        (int)cboSupplier.SelectedValue,

                    UnitPrice = numPrice.Value,

                    StockQuantity =
                        (int)numStock.Value
                };

                _productService.Add(dto);

                MessageBox.Show(
                    "Product added successfully");

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
