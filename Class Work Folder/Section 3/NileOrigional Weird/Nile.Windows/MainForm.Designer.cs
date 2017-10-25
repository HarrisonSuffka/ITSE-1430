namespace Nile.Windows
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._MiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._MiProductAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._MiProductEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._MiProductDelete = new System.Windows.Forms.ToolStripMenuItem();
            this._MiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._MiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._GridProducts = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDiscontinuedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._BSProducts = new System.Windows.Forms.BindingSource(this.components);
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BSProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productToolStripMenuItem,
            this._MiHelp});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(596, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MiFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _MiFileExit
            // 
            this._MiFileExit.Name = "_MiFileExit";
            this._MiFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._MiFileExit.Size = new System.Drawing.Size(134, 22);
            this._MiFileExit.Text = "&Exit";
            this._MiFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MiProductAdd,
            this._MiProductEdit,
            this.toolStripSeparator1,
            this._MiProductDelete});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "&Product";
            // 
            // _MiProductAdd
            // 
            this._MiProductAdd.Name = "_MiProductAdd";
            this._MiProductAdd.Size = new System.Drawing.Size(131, 22);
            this._MiProductAdd.Text = "&Add";
            this._MiProductAdd.Click += new System.EventHandler(this.OnProductAdd);
            // 
            // _MiProductEdit
            // 
            this._MiProductEdit.Name = "_MiProductEdit";
            this._MiProductEdit.Size = new System.Drawing.Size(131, 22);
            this._MiProductEdit.Text = "&Edit";
            this._MiProductEdit.Click += new System.EventHandler(this.OnProductEdit);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // _MiProductDelete
            // 
            this._MiProductDelete.Name = "_MiProductDelete";
            this._MiProductDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._MiProductDelete.Size = new System.Drawing.Size(131, 22);
            this._MiProductDelete.Text = "&Delete";
            this._MiProductDelete.Click += new System.EventHandler(this.OnProductDelete);
            // 
            // _MiHelp
            // 
            this._MiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MiHelpAbout});
            this._MiHelp.Name = "_MiHelp";
            this._MiHelp.Size = new System.Drawing.Size(44, 20);
            this._MiHelp.Text = "&Help";
            // 
            // _MiHelpAbout
            // 
            this._MiHelpAbout.Name = "_MiHelpAbout";
            this._MiHelpAbout.Size = new System.Drawing.Size(107, 22);
            this._MiHelpAbout.Text = "&About";
            this._MiHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // _GridProducts
            // 
            this._GridProducts.AllowUserToAddRows = false;
            this._GridProducts.AllowUserToDeleteRows = false;
            this._GridProducts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Empty;
            this._GridProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._GridProducts.AutoGenerateColumns = false;
            this._GridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._GridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.isDiscontinuedDataGridViewCheckBoxColumn});
            this._GridProducts.DataSource = this._BSProducts;
            this._GridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GridProducts.Location = new System.Drawing.Point(0, 24);
            this._GridProducts.Name = "_GridProducts";
            this._GridProducts.ReadOnly = true;
            this._GridProducts.RowHeadersVisible = false;
            this._GridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._GridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._GridProducts.Size = new System.Drawing.Size(596, 312);
            this._GridProducts.TabIndex = 1;
            this._GridProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnEditRow);
            this._GridProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownGrid);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 300F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // isDiscontinuedDataGridViewCheckBoxColumn
            // 
            this.isDiscontinuedDataGridViewCheckBoxColumn.DataPropertyName = "IsDiscontinued";
            this.isDiscontinuedDataGridViewCheckBoxColumn.HeaderText = "Is Discontinued?";
            this.isDiscontinuedDataGridViewCheckBoxColumn.Name = "isDiscontinuedDataGridViewCheckBoxColumn";
            this.isDiscontinuedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // _BSProducts
            // 
            this._BSProducts.AllowNew = false;
            this._BSProducts.DataSource = typeof(Nile.Product);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(596, 336);
            this.Controls.Add(this._GridProducts);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Nile";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BSProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _MiFileExit;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _MiProductAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _MiProductEdit;
        private System.Windows.Forms.ToolStripMenuItem _MiProductDelete;
        private System.Windows.Forms.ToolStripMenuItem _MiHelp;
        private System.Windows.Forms.ToolStripMenuItem _MiHelpAbout;
        private System.Windows.Forms.DataGridView _GridProducts;
        private System.Windows.Forms.BindingSource _BSProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDiscontinuedDataGridViewCheckBoxColumn;
    }
}

