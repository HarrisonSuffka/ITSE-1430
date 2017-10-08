using System;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        
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

            //TODO:Save Product

            _product = child.Product;
        }

        private void OnProductEdit( object sender, EventArgs e )
        {
            var child = new ProductDetailForm("Product Details");
            child.Product = _product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO:Save Product

            _product = child.Product;
        }

        private void OnProductDelete( object sender, EventArgs e )
        {
            if (_product == null)
                return;

            //Confirm

            if (MessageBox.Show(this, $"Are you sure you want to delete '{ _product.Name}'?", "Delete",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //TODO: Delete Product
            _product = null;
        }

        private Product _product;

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var about = new AboutBox();
            about.ShowDialog(this);
        }


    }
}
