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

namespace TechSales.WinForms.Forms.Invoice
{
    public partial class InvoicesControl : UserControl
    {
        private readonly InvoiceService _invoiceService;
        private readonly TechSalesDbContext _db;

        public InvoicesControl(TechSalesDbContext db)
        {
            InitializeComponent();

            _db = db;

            _invoiceService =
                new InvoiceService(db);

            ConfigureGrid();

            LoadInvoices();
        }

        private void dgvInvoices_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInvoices.ClearSelection();
        }

        private void ConfigureGrid()
        {
            dgvInvoices.EnableHeadersVisualStyles = false;

            dgvInvoices.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                dgvInvoices.ColumnHeadersDefaultCellStyle.BackColor;

            dgvInvoices.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                dgvInvoices.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void LoadInvoices()
        {
            dgvInvoices.DataSource = _invoiceService.GetAllForList();

            dgvInvoices.Columns["Id"].HeaderText = "#";
            dgvInvoices.Columns["Id"].FillWeight = 25;
            dgvInvoices.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvInvoices.Columns["Status"].FillWeight = 80;
            dgvInvoices.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvInvoices.Columns["CustomerName"].HeaderText = "Customer";

            dgvInvoices.Columns["InvoiceDate"].HeaderText = "Date";
            dgvInvoices.Columns["InvoiceDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvInvoices.Columns["TotalAmount"].HeaderText = "Total";

            dgvInvoices.Columns["PaidAmount"].HeaderText = "Paid";

            dgvInvoices.Columns["RemainingAmount"].HeaderText = "Remaining";

            dgvInvoices.Columns["TotalAmount"].DefaultCellStyle.Format = "$#,##0.00";

            dgvInvoices.Columns["PaidAmount"].DefaultCellStyle.Format = "$#,##0.00";

            dgvInvoices.Columns["RemainingAmount"].DefaultCellStyle.Format = "$#,##0.00";

            dgvInvoices.Columns["InvoiceDate"].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm";
        }

        private void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInvoices.Columns[e.ColumnIndex].Name != "Status")
                return;

            string status = e.Value?.ToString() ?? "";

            if (status == "Paid")
            {
                e.CellStyle.ForeColor = Color.Green;
            }
            else if (status == "Partial")
            {
                e.CellStyle.ForeColor = Color.DarkOrange;
            }
            else
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvInvoices.DataSource = _invoiceService.Search(txtSearch.Text);
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            var form = new CreateInvoiceForm(_db);

            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                LoadInvoices();
            }
        }

        private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int invoiceId =
                (int)dgvInvoices
                    .Rows[e.RowIndex]
                    .Cells["Id"]
                    .Value;

            var form = new InvoiceDetailsForm(_db, invoiceId);

            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                LoadInvoices();
            }
        }
    }
}
