namespace Steam_Desktop_Authenticator
{
    partial class CaptchaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchaForm));
            this.labelText = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAccept = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Depth = 0;
            this.labelText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelText.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelText.Location = new System.Drawing.Point(0, 13);
            this.labelText.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(233, 51);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Please enter the following captcha code:";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(12, 73);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(208, 40);
            this.pictureBoxCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptcha.TabIndex = 4;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // txtBox
            // 
            this.txtBox.Depth = 0;
            this.txtBox.Hint = "";
            this.txtBox.Location = new System.Drawing.Point(12, 119);
            this.txtBox.MaxLength = 32767;
            this.txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox.Name = "txtBox";
            this.txtBox.PasswordChar = '\0';
            this.txtBox.SelectedText = "";
            this.txtBox.SelectionLength = 0;
            this.txtBox.SelectionStart = 0;
            this.txtBox.Size = new System.Drawing.Size(208, 23);
            this.txtBox.TabIndex = 12;
            this.txtBox.TabStop = false;
            this.txtBox.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(120, 151);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(64, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.AutoSize = true;
            this.btnAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccept.Depth = 0;
            this.btnAccept.Location = new System.Drawing.Point(48, 151);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Primary = false;
            this.btnAccept.Size = new System.Drawing.Size(62, 36);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Submit";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // CaptchaForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(232, 202);
            this.ControlBox = false;
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Controls.Add(this.labelText);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaptchaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelText;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtBox;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private MaterialSkin.Controls.MaterialFlatButton btnAccept;
    }
}