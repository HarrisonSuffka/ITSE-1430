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
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDiscontinued = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GridProducts)).BeginInit();
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
            this.MainMenu.Size = new System.Drawing.Size(618, 24);
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
            this._GridProducts.AllowUserToOrderColumns = true;
            this._GridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._GridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colDescription,
            this.colPrice,
            this.colIsDiscontinued});
            this._GridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GridProducts.Location = new System.Drawing.Point(0, 24);
            this._GridProducts.Name = "_GridProducts";
            this._GridProducts.Size = new System.Drawing.Size(618, 436);
            this._GridProducts.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // colIsDiscontinued
            // 
            this.colIsDiscontinued.HeaderText = "Is Discontinued?";
            this.colIsDiscontinued.Name = "colIsDiscontinued";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(618, 460);
            this.Controls.Add(this._GridProducts);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Nile";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GridProducts)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsDiscontinued;
    }
}

