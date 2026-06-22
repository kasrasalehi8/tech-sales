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

namespace TechSales.WinForms.Forms.Customer
{
    public partial class CustomerDetailsForm : Form
    {
        private readonly CustomerService _customerService;
        private readonly int _customerId;

        public CustomerDetailsForm(TechSalesDbContext db, int customerId)
        {
            InitializeComponent();

            _customerService =
                new CustomerService(db);

            _customerId = customerId;

            LoadCustomer();
        }

        private void LoadCustomer()
        {
            var customer =
                _customerService.GetById(_customerId);

            if (customer == null)
            {
                MessageBox.Show("Customer not found");
                Close();
                return;
            }

            lblNameValue.Text =
                customer.FullName;

            lblPhoneNumberValue.Text =
                customer.Phone ?? "N/A";

            txtAddress.Text =
                customer.Address ?? "N/A";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Delete this customer?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            _customerService.Delete(_customerId);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
