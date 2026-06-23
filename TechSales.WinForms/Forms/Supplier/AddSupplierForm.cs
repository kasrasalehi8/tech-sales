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

namespace TechSales.WinForms.Forms.Supplier
{
    public partial class AddSupplierForm : Form
    {
        private readonly SupplierService _supplierService;

        public AddSupplierForm(TechSalesDbContext db)
        {
            InitializeComponent();

            _supplierService = new SupplierService(db);
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dto =
                    new AddSupplierDto
                    {
                        CompanyName =
                            txtCompanyName.Text,

                        Phone =
                            txtPhoneNumber.Text,

                        Address =
                            txtAddress.Text
                    };

                _supplierService.Add(dto);

                MessageBox.Show(
                    "Supplier added successfully");

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
            Close();
        }
    }
}
