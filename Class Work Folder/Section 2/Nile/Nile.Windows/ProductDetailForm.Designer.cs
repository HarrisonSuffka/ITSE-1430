namespace Nile.Windows
{
    partial class ProductDetailForm
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
            this._LbName = new System.Windows.Forms.Label();
            this._lbDescription = new System.Windows.Forms.Label();
            this._LbPrice = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._chkDiscontinued = new System.Windows.Forms.CheckBox();
            this._bntCancel = new System.Windows.Forms.Button();
            this._bntSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _LbName
            // 
            this._LbName.AutoSize = true;
            this._LbName.Location = new System.Drawing.Point(0, 19);
            this._LbName.Name = "_LbName";
            this._LbName.Size = new System.Drawing.Size(38, 13);
            this._LbName.TabIndex = 0;
            this._LbName.Text = "Name:";
            // 
            // _lbDescription
            // 
            this._lbDescription.AutoSize = true;
            this._lbDescription.Location = new System.Drawing.Point(0, 111);
            this._lbDescription.Name = "_lbDescription";
            this._lbDescription.Size = new System.Drawing.Size(63, 13);
            this._lbDescription.TabIndex = 2;
            this._lbDescription.Text = "Description:";
            // 
            // _LbPrice
            // 
            this._LbPrice.AutoSize = true;
            this._LbPrice.Location = new System.Drawing.Point(0, 221);
            this._LbPrice.Name = "_LbPrice";
            this._LbPrice.Size = new System.Drawing.Size(34, 13);
            this._LbPrice.TabIndex = 3;
            this._LbPrice.Text = "Price:";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(94, 12);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 20);
            this._txtName.TabIndex = 4;
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(94, 108);
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(100, 20);
            this._txtDescription.TabIndex = 5;
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(94, 217);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(100, 20);
            this._txtPrice.TabIndex = 6;
            // 
            // _chkDiscontinued
            // 
            this._chkDiscontinued.AutoSize = true;
            this._chkDiscontinued.Location = new System.Drawing.Point(344, 220);
            this._chkDiscontinued.Name = "_chkDiscontinued";
            this._chkDiscontinued.Size = new System.Drawing.Size(105, 17);
            this._chkDiscontinued.TabIndex = 11;
            this._chkDiscontinued.Text = "Is Discontinued?";
            this._chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // _bntCancel
            // 
            this._bntCancel.Location = new System.Drawing.Point(371, 293);
            this._bntCancel.Name = "_bntCancel";
            this._bntCancel.Size = new System.Drawing.Size(75, 23);
            this._bntCancel.TabIndex = 12;
            this._bntCancel.Text = "Cancel";
            this._bntCancel.UseVisualStyleBackColor = true;
            this._bntCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _bntSave
            // 
            this._bntSave.Location = new System.Drawing.Point(262, 293);
            this._bntSave.Name = "_bntSave";
            this._bntSave.Size = new System.Drawing.Size(75, 23);
            this._bntSave.TabIndex = 13;
            this._bntSave.Text = "Save";
            this._bntSave.UseVisualStyleBackColor = true;
            this._bntSave.Click += new System.EventHandler(this.OnSave);
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 322);
            this.Controls.Add(this._bntSave);
            this.Controls.Add(this._bntCancel);
            this.Controls.Add(this._chkDiscontinued);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._LbPrice);
            this.Controls.Add(this._lbDescription);
            this.Controls.Add(this._LbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductDetailForm";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Details";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProductDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _LbName;
        private System.Windows.Forms.Label _lbDescription;
        private System.Windows.Forms.Label _LbPrice;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.TextBox _txtPrice;
        private System.Windows.Forms.CheckBox _chkDiscontinued;
        private System.Windows.Forms.Button _bntCancel;
        private System.Windows.Forms.Button _bntSave;
    }
}