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

namespace TechSales.WinForms.Forms.Customer
{
    public partial class AddCustomerForm : Form
    {
        private readonly CustomerService _customerService;

        public AddCustomerForm(TechSalesDbContext db)
        {
            InitializeComponent();

            _customerService =
                new CustomerService(db);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new AddCustomerDto
                {
                    FullName = txtFullName.Text,

                    Phone =
                        txtPhoneNumber.Text,

                    Address =
                        txtAddress.Text
                };

                _customerService.Add(dto);

                MessageBox.Show("Customer added successfully");

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

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
