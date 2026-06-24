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
    public partial class InvoiceDetailsForm : Form
    {
        private readonly InvoiceService _invoiceService;
        private readonly PaymentService _paymentService;
        private readonly TechSalesDbContext _db;

        private readonly int _invoiceId;

        public InvoiceDetailsForm(TechSalesDbContext db, int invoiceId)
        {
            InitializeComponent();

            ConfigureGrid(dgvItems);
            ConfigureGrid(dgvPayments);

            _db = db;

            _invoiceId = invoiceId;

            _invoiceService =
                new InvoiceService(db);

            _paymentService =
                new PaymentService(db);

            LoadInvoice();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            dgvItems.ClearSelection();
            dgvPayments.ClearSelection();
        }

        private void ConfigureGrid(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                dgv.ColumnHeadersDefaultCellStyle.BackColor;

            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                dgv.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void SetSaveButtonEnabled(bool enabled)
        {
            btnAddPayment.Enabled = enabled;

            if (enabled)
            {
                btnAddPayment.BackColor = Color.FromArgb(3, 38, 53);
                btnAddPayment.ForeColor = Color.White;
                btnAddPayment.Cursor = Cursors.Hand;
            }
            else
            {
                btnAddPayment.BackColor = Color.LightGray;
                btnAddPayment.ForeColor = Color.DarkGray;
                btnAddPayment.Cursor = Cursors.Default;
                btnAddPayment.Enabled = false;
            }
        }

        private void LoadInvoice()
        {
            SetSaveButtonEnabled(false);

            var invoice = _invoiceService.GetDetails(_invoiceId);

            if (invoice == null)
            {
                MessageBox.Show("Invoice not found.");

                Close();

                return;
            }

            lblInvoiceNumberValue.Text =
                $"#{invoice.Id}";

            lblCustomerValue.Text =
                invoice.CustomerName;

            lblDateValue.Text =
                invoice.InvoiceDate
                    .ToString("yyyy/MM/dd HH:mm");

            lblTotalAmountValue.Text =
                invoice.TotalAmount.ToString("$#,##0.00");

            lblPaidAmountValue.Text =
                invoice.PaidAmount.ToString("$#,##0.00");

            lblRemainingValue.Text =
                invoice.RemainingAmount.ToString("$#,##0.00");

            lblPaymentStatus.Text =
                $"[{invoice.Status.ToUpper()}]";

            dgvItems.DataSource = invoice.Items;

            dgvItems.Columns["ProductName"].HeaderText =
                "Product";

            dgvItems.Columns["UnitPrice"].HeaderText =
                "Price";

            dgvItems.Columns["Quantity"].HeaderText =
                "Qty";

            dgvItems.Columns["LineTotal"].HeaderText =
                "Total";

            dgvItems.Columns["UnitPrice"]
                .DefaultCellStyle.Format =
                    "$#,##0.00";

            dgvItems.Columns["LineTotal"]
                .DefaultCellStyle.Format =
                    "$#,##0.00";

            dgvPayments.DataSource = invoice.Payments;

            dgvPayments.Columns["PaymentDate"]
                .HeaderText =
                    "Date";

            dgvPayments.Columns["Amount"]
                .HeaderText =
                    "Amount";

            dgvPayments.Columns["PaymentDate"]
                .DefaultCellStyle.Format =
                    "yyyy/MM/dd HH:mm";

            dgvPayments.Columns["Amount"]
                .DefaultCellStyle.Format =
                    "$#,##0.00";

            switch (invoice.Status)
            {
                case "Paid":
                    lblPaymentStatus.ForeColor = Color.Green;
                    break;

                case "Partial":
                    lblPaymentStatus.ForeColor = Color.DarkOrange;
                    SetSaveButtonEnabled(true);
                    break;

                default:
                    lblPaymentStatus.ForeColor = Color.Red;
                    SetSaveButtonEnabled(true);
                    break;
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            var form =
                new AddPaymentForm(
                    _db,
                    _invoiceId);

            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                LoadInvoice();

                DialogResult =
                    DialogResult.OK;
            }
        }
    }
}
