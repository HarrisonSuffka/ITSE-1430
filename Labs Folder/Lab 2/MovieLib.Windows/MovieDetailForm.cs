using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLib.Windows
{
    public partial class MovieDetailForm : Form
    {

        #region Construction
        public MovieDetailForm() 
        {
            InitializeComponent();
        }

        public MovieDetailForm( string title ) : this()
        {
            Text = title;
        }

        public MovieDetailForm( string title, Movie movie ) : this(title)
        {
            Movie = movie;
        }
        #endregion

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if (Movie != null)
            {
                _txtTitle.Text = Movie.Title;
                _txtDescription.Text = Movie.Description;
                _txtLength.Text = Movie.Price.ToString();
                _chkOwned.Checked = Movie.IsDiscontinued;
            };
        }

        /// <summary>Gets or sets the Movie being shown</summary>
        public Movie Movie { get; set; }


        private void ShowError( string message, string title )
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSave( object sender, EventArgs e )
        {
            var product = new Movie();
            product.Name = _txtTitle.Text;
            product.Description = _txtDescription.Text;
            product.Price = GetLength();
            product.IsDiscontinued = _chkOwned.Checked;

            // Add Validation
            var error = movie.Validate();
            if (!String.IsNullOrEmpty(error))
            {

                ShowError(error, "Validation Error");
                return;
            }

            Movie = movie;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private decimal GetLength()
        {
            if (Decimal.TryParse(_txtLength.Text, out decimal length))
                return length;
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
