namespace MovieLib.Windows
{
    partial class MovieDetailForm
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
            this._txtTitle = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._txtLength = new System.Windows.Forms.TextBox();
            this._chkOwned = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtTitle
            // 
            this._txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtTitle.Location = new System.Drawing.Point(122, 9);
            this._txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtTitle.Name = "_txtTitle";
            this._txtTitle.Size = new System.Drawing.Size(650, 26);
            this._txtTitle.TabIndex = 0;
            this._txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingTitle);
            // 
            // _txtDescription
            // 
            this._txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtDescription.Location = new System.Drawing.Point(122, 65);
            this._txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(650, 222);
            this._txtDescription.TabIndex = 1;
            // 
            // _txtLength
            // 
            this._txtLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._txtLength.Location = new System.Drawing.Point(140, 323);
            this._txtLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtLength.Name = "_txtLength";
            this._txtLength.Size = new System.Drawing.Size(148, 26);
            this._txtLength.TabIndex = 2;
            this._txtLength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingLength);
            // 
            // _chkOwned
            // 
            this._chkOwned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._chkOwned.AutoSize = true;
            this._chkOwned.Location = new System.Drawing.Point(140, 388);
            this._chkOwned.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._chkOwned.Name = "_chkOwned";
            this._chkOwned.Size = new System.Drawing.Size(85, 24);
            this._chkOwned.TabIndex = 3;
            this._chkOwned.Text = "Owned";
            this._chkOwned.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Length:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "minutes";
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.Location = new System.Drawing.Point(512, 386);
            this._btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(112, 35);
            this._btnSave.TabIndex = 4;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.CausesValidation = false;
            this._btnCancel.Location = new System.Drawing.Point(662, 386);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(112, 35);
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // MovieDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(826, 486);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._chkOwned);
            this.Controls.Add(this._txtLength);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(594, 342);
            this.Name = "MovieDetailForm";
            this.Text = "Movie Details";
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtTitle;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.TextBox _txtLength;
        private System.Windows.Forms.CheckBox _chkOwned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}