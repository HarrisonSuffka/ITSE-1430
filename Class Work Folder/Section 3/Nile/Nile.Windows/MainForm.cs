using System;
using System.Linq;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _GridProducts.AutoGenerateColumns = false;

            UpdateList();

        }

        private Product GetSelectedProduct ()
        {
            //return _listProducts.SelectedItem as Product;
            if (_GridProducts.SelectedRows.Count > 0)
                return _GridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList()
        {
            _BSProducts.DataSource = _database.GetAll().ToList();
        }

      

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }


        private void OnProductAdd( object sender, EventArgs e )
        {


            var child = new ProductDetailForm("Product Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            _database.Add(child.Product);
            UpdateList();

        }

        private void OnProductEdit( object sender, EventArgs e )
        {

            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("No products available");
                return;
            }

            EditProduct(product);

        }

        private void EditProduct( Product product )
        {
            var child = new ProductDetailForm("Product Details") {
                Product = product
            };
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            _database.Update(child.Product);
            UpdateList();
        }

        private void OnProductDelete( object sender, EventArgs e )
        {

            var product = GetSelectedProduct();
            if (product == null)
                return;

            DeleteProduct(product);

        }

        private void DeleteProduct( Product product )
        {
            if (MessageBox.Show(this, $"Are you sure you want to delete '{ product.Name}'?", "Delete",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _database.Remove(product.Id);
            UpdateList();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var about = new AboutBox();
            about.ShowDialog(this);
        }

        public delegate void ButtonClickCall( object sender, EventArgs e );


        private void CallButton( ButtonClickCall functionToCall )
        {
            functionToCall(this, EventArgs.Empty);
        }

        //private Product[] _products = new Product[100];
        private IProductDatabase _database = new Nile.Stores.SeedMemoryProductDatabase();

        private void OnEditRow( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Product;

            if (item != null)
                EditProduct(item);
        }

        private void OnKeyDownGrid( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var product = GetSelectedProduct();
            if (product != null)
                DeleteProduct(product);

        }
    }
}
