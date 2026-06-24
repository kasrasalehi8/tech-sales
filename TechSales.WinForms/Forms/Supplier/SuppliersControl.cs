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
    public partial class SuppliersControl : UserControl
    {
        private readonly SupplierService _supplierService;
        private readonly TechSalesDbContext _db;

        public SuppliersControl(TechSalesDbContext db)
        {
            InitializeComponent();

            _db = db;

            ConfigureGrid();

            _supplierService =
                new SupplierService(db);

            LoadSuppliers();
        }

        private void dgvSuppliers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSuppliers.ClearSelection();
        }

        private void ConfigureGrid()
        {
            dgvSuppliers.EnableHeadersVisualStyles = false;

            dgvSuppliers.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor;

            dgvSuppliers.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void LoadSuppliers()
        {
            dgvSuppliers.DataSource =
                _supplierService.GetSupplierList();

            if (dgvSuppliers.Columns["Id"] != null)
                dgvSuppliers.Columns["Id"].Visible = false;

            if (dgvSuppliers.Columns["Products"] != null)
                dgvSuppliers.Columns["Products"].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSuppliers.DataSource =
                _supplierService.Search(
                    txtSearch.Text);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var form =
                new AddSupplierForm(_db);

            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                LoadSuppliers();
            }
        }

        private void dgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int supplierId =
                (int)dgvSuppliers.Rows[e.RowIndex]
                    .Cells["Id"].Value;

            var form =
                new SupplierDetailsForm(
                    _db,
                    supplierId);

            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                LoadSuppliers();
            }
        }
    }
}
