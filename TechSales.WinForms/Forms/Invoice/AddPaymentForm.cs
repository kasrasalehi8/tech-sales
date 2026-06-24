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
    public partial class AddPaymentForm : Form
    {
        private readonly PaymentService _paymentService;
        private readonly InvoiceService _invoiceService;

        private readonly int _invoiceId;

        public AddPaymentForm(TechSalesDbContext db, int invoiceId)
        {
            InitializeComponent();

            _invoiceId = invoiceId;

            _paymentService =
                new PaymentService(db);

            _invoiceService =
                new InvoiceService(db);

            LoadInvoice();
        }

        private void LoadInvoice()
        {
            var invoice =
                _invoiceService.GetDetails(_invoiceId);

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

            lblRemainingBalanceValue.Text =
                invoice.RemainingAmount
                    .ToString("$#,##0.00");

            numAmount.Maximum =
                invoice.RemainingAmount;

            numAmount.Value =
                invoice.RemainingAmount;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _paymentService.Create(
                    new AddPaymentDto
                    {
                        InvoiceId = _invoiceId,
                        Amount =numAmount.Value,
                        PaymentDate = dtpPaymentDate.Value
                    });

                MessageBox.Show("Payment added successfully.");

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
