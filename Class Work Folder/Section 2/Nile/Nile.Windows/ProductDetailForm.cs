using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class ProductDetailForm : Form
    {

        #region Construction
        public ProductDetailForm() //: base()
        {
            InitializeComponent();
        }

        public ProductDetailForm( string title ) : this()
        {

            Text = title;
        }

        public ProductDetailForm( string title , Product product) : this(title)
        {
            Product = product;
        }
        #endregion

         protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if ( Product != null)
            {
                _txtName.Text = Product.Name;
                _txtDescription.Text = Product.Description;
                _txtPrice.Text = Product.Price.ToString();
                _chkDiscontinued.Checked = Product.IsDiscontinued;
            };
        }

        /// <summary>Gets or sets the product being shown</summary>
        public Product Product { get; set; }

        private void ProductDetailForm_Load( object sender, EventArgs e )
        {

        }

        private void ShowError ( string message, string title )
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSave( object sender, EventArgs e )
        {
            var product = new Product();
            product.Name = _txtName.Text;
            product.Description = _txtDescription.Text;
            product.Price = GetPrice();
            product.IsDiscontinued = _chkDiscontinued.Checked;

            // Add Validation
            var error = product.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                //Show the error
                //MessageBox.Show(this, error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowError(error, "Validation Error");
                return;
            }

            Product = product;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private decimal GetPrice ()
        {
            if (Decimal.TryParse(_txtPrice.Text, out decimal price))
                return price;
            //TODO: Validate Price
            return 0;
        }

        private void OnCancel( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
