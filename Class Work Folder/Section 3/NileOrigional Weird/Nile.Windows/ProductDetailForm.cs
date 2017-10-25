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


        private void ShowError ( string message, string title )
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSave( object sender, EventArgs e )
        {
            //var product = new Product();
            //product.Id = Product?.Id ?? 0;
            //product.Name = _txtName.Text;
            //product.Description = _txtDescription.Text;
            //product.Price = GetPrice(_txtPrice);
            //product.IsDiscontinued = _chkDiscontinued.Checked;

            var product = new Product() 
            {
                Id = Product?.Id ?? 0,
                Name = _txtName.Text,
                Description = _txtDescription.Text,
                Price = GetPrice(_txtPrice),
                IsDiscontinued = _chkDiscontinued.Checked,
            };

            //Using IValidatableObject
            if (!ObjectValidator.TryValidate(product, out var errors))
            {
                //Show the error
                //MessageBox.Show(this, error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowError("Not Valid", "Validation Error");
                return;
            }

            // Add Validation
            //if (!String.IsNullOrEmpty(error))
            //var error = product.Validate();
            //{
            //    //Show the error
            //    //MessageBox.Show(this, error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    ShowError(error, "Validation Error");
            //    return;
            //}

            Product = product;
            DialogResult = DialogResult.OK;
            Close();
        }

        private decimal GetPrice ( TextBox control )
        {
            if (Decimal.TryParse(_txtPrice.Text, out decimal price))
                return price;
            //TODO: Validate Price
            return 0;
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnValidatingPrice( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (GetPrice(tb) < 0)
            {
                e.Cancel = true;
                _errors.SetError(_txtPrice, "Price must be >= 0.");
            } else
                _errors.SetError(_txtPrice, "");
        }

        private void OnValidatingName( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;
            if (String.IsNullOrEmpty(tb.Text))
                _errors.SetError(tb, "Name is required");
            else
                _errors.SetError(tb, "");
        }
    }
}
