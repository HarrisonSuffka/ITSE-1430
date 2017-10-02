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
            var child = new MovieDetailForm("Product Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO:Save Product

            _movie = child.Movie;
        }

        private void OnProductEdit( object sender, EventArgs e )
        {
            var child = new MovieDetailForm("Product Details");
            child.Movie = _movie;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO:Save Product

            _movie = child.Movie;
        }

        private void OnProductDelete( object sender, EventArgs e )
        {
            if (_movie == null)
                return;

            //Confirm

            if (MessageBox.Show(this, $"Are you sure you want to delete '{ _title.Name}'?", "Delete",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //TODO: Delete Product
            _movie = null;
        }

        private Movie _movie;

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var about = new AboutBox();
            about.ShowDialog(this);
        }

    }
}
