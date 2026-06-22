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
    public partial class CustomersControl : UserControl
    {
        private readonly CustomerService _customerService;
        private readonly TechSalesDbContext _db;

        public CustomersControl(TechSalesDbContext db)
        {
            InitializeComponent();

            _db = db;

            ConfigureGrid();

            _customerService =
                new CustomerService(db);

            LoadCustomers();
        }

        private void ConfigureGrid()
        {
            dgvCustomers.EnableHeadersVisualStyles = false;

            dgvCustomers.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor;

            dgvCustomers.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void LoadCustomers()
        {
            dgvCustomers.DataSource =
                _customerService.GetAll();

            if (dgvCustomers.Columns["Id"] != null)
                dgvCustomers.Columns["Id"].Visible = false;

            if (dgvCustomers.Columns["CreatedAt"] != null)
                dgvCustomers.Columns["CreatedAt"].Visible = false;

            if (dgvCustomers.Columns["Invoices"] != null)
                dgvCustomers.Columns["Invoices"].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.DataSource =
                _customerService.Search(
                    txtSearch.Text);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var form = new AddCustomerForm(_db);

            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void dgvCustomers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int customerId =
                (int)dgvCustomers.Rows[e.RowIndex]
                    .Cells["Id"].Value;

            var form =
                new CustomerDetailsForm(
                    _db,
                    customerId);

            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                LoadCustomers();
            }
        }
    }
}
