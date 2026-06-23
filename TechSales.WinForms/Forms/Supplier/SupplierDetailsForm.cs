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
using TechSales.Infrastructure.Persistence;

namespace TechSales.WinForms.Forms.Supplier
{
    public partial class SupplierDetailsForm : Form
    {
        private readonly SupplierService _supplierService;
        private readonly int _supplierId;

        public SupplierDetailsForm(TechSalesDbContext db, int supplierId)
        {
            InitializeComponent();

            _supplierService =
                new SupplierService(db);

            _supplierId = supplierId;

            LoadSupplier();
        }

        private void LoadSupplier()
        {
            var supplier =
                _supplierService.GetbyId(_supplierId);

            if (supplier == null)
            {
                MessageBox.Show("Supplier not found");

                Close();

                return;
            }

            lblCompanyNameValue.Text =
                supplier.CompanyName;

            lblPhoneNumberValue.Text =
                string.IsNullOrWhiteSpace(supplier.Phone)
                    ? "N/A"
                    : supplier.Phone;

            txtAddress.Text =
                string.IsNullOrWhiteSpace(supplier.Address)
                    ? "N/A"
                    : supplier.Address;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result =
                MessageBox.Show(
                    "Are you sure you want to delete this supplier?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _supplierService.Delete(_supplierId);

                MessageBox.Show(
                    "Supplier deleted successfully");

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
