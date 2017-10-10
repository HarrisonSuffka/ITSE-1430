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

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            var products = _database.GetAll();

        }

        //private int FindAvailableElement()
        //{
        //    for ( var i = 0; i< _products.Length; ++i)
        //    {
        //        if (_products[i] == null)
        //            return i;
        //    };

        //    return -1;
        //}

        //private int FindFirstProduct()
        //{
        //    for (var i = 0; i < _products.Length; ++i)
        //    {
        //        if (_products[i] != null)
        //            return i;
        //    };

        //    return -1;
        //}

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }


        private void OnProductAdd( object sender, EventArgs e )
        {
            ////var index = FindAvailableElement();
            //if (index == _products.Length)
            //{
            //    MessageBox.Show("No more products available");
            //}

            var child = new ProductDetailForm("Product Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            _database.Add(child.Product);
        }

        private void OnProductEdit( object sender, EventArgs e )
        {
            ////Are there any products
            //var index = FindFirstProduct();

            //if (index < 0)
            //{
            //    MessageBox.Show("No more products available");
            //    return;
            //}

            var product = _database.Get();

            var child = new ProductDetailForm("Product Details");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO:Save Product

            _database.Update(child.Product);
        }

        private void OnProductDelete( object sender, EventArgs e )
        {
            //var index = FindFirstProduct();

            //if (index < 0)
            //    return;

            //var _product = _products[index]; 
            var product = _database.Get();
            //Confirm

            if (MessageBox.Show(this, $"Are you sure you want to delete '{ product.Name}'?", "Delete",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //TODO: Delete Product
            _database.Remove(product);
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
        private ProductDatabase _database = new ProductDatabase();

    }
}
