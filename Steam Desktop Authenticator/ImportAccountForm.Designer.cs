namespace Steam_Desktop_Authenticator
{
    partial class ImportAccountForm
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportAccountForm));
            this.labelText = new MaterialSkin.Controls.MaterialLabel();
            this.txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnImport = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Depth = 0;
            this.labelText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelText.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelText.Location = new System.Drawing.Point(14, 70);
            this.labelText.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(293, 41);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Enter your encryption passkey if your .maFileis encrypted:";
            // 
            // txtBox
            // 
            this.txtBox.Depth = 0;
            this.txtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Hint = "";
            this.txtBox.Location = new System.Drawing.Point(14, 115);
            this.txtBox.MaxLength = 32767;
            this.txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox.Name = "txtBox";
            this.txtBox.PasswordChar = '\0';
            this.txtBox.SelectedText = "";
            this.txtBox.SelectionLength = 0;
            this.txtBox.SelectionStart = 0;
            this.txtBox.Size = new System.Drawing.Size(293, 23);
            this.txtBox.TabIndex = 1;
            this.txtBox.TabStop = false;
            this.txtBox.UseSystemPasswordChar = true;
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.Depth = 0;
            this.btnImport.Location = new System.Drawing.Point(86, 201);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImport.Name = "btnImport";
            this.btnImport.Primary = false;
            this.btnImport.Size = new System.Drawing.Size(221, 36);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Select .maFile file to Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(14, 201);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(64, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Depth = 0;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 141);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "If you import an encrypted .maFile, the manifest file must be next to it.";
            // 
            // ImportAccountForm
            // 
            this.AcceptButton = this.btnImport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(320, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.labelText);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImportAccountForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Import_maFile_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelText;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBox;
        private MaterialSkin.Controls.MaterialFlatButton btnImport;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel label1;
    }
}
