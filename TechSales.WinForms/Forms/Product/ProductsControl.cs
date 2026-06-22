using TechSales.Application.Services;
using TechSales.Infrastructure.Persistence;
using TechSales.WinForms.Forms.Product;

namespace TechSales.WinForms.Forms
{
    public partial class ProductsControl : UserControl
    {
        private readonly ProductService _productService;
        private readonly TechSalesDbContext _db;

        public ProductsControl(TechSalesDbContext db)
        {
            InitializeComponent();

            _db = db;

            ConfigureGrid();

            _productService = new ProductService(db);

            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;

            LoadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var form = new AddProductForm(_db);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void ConfigureGrid()
        {
            dgvProducts.EnableHeadersVisualStyles = false;

            dgvProducts.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                dgvProducts.ColumnHeadersDefaultCellStyle.BackColor;

            dgvProducts.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = _productService.GetProductList();
            if (dgvProducts.Columns["Id"] != null)
                dgvProducts.Columns["Id"].Visible = false;

            if (dgvProducts.Columns["IsActive"] != null)
                dgvProducts.Columns["IsActive"].Visible = false;

            if (dgvProducts.Columns["Price"] != null)
                dgvProducts.Columns["Price"].DefaultCellStyle.Format = "$0.00";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = _productService.Search(txtSearch.Text);
        }

        private void dgvProducts_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int productId =
                (int)dgvProducts.Rows[e.RowIndex]
                    .Cells["Id"].Value;

            var form =
                new ProductDetailsForm(
                    _db,
                    productId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }
    }
}
