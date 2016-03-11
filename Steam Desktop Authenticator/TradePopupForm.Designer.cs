namespace Steam_Desktop_Authenticator
{
    partial class TradePopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradePopupForm));
            this.lblDesc = new MaterialSkin.Controls.MaterialLabel();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.lblAccount = new MaterialSkin.Controls.MaterialLabel();
            this.btnDeny = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAccept = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Depth = 0;
            this.lblDesc.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDesc.Location = new System.Drawing.Point(4, 92);
            this.lblDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(195, 38);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "trade description";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(2, 130);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(199, 29);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "press again to confirm";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccount
            // 
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Depth = 0;
            this.lblAccount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAccount.Location = new System.Drawing.Point(2, 69);
            this.lblAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(199, 23);
            this.lblAccount.TabIndex = 4;
            this.lblAccount.Text = "account name";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeny
            // 
            this.btnDeny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeny.Depth = 0;
            this.btnDeny.Location = new System.Drawing.Point(30, 162);
            this.btnDeny.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Primary = true;
            this.btnDeny.Size = new System.Drawing.Size(68, 32);
            this.btnDeny.TabIndex = 2;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = false;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAccept.Depth = 0;
            this.btnAccept.Location = new System.Drawing.Point(104, 162);
            this.btnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Primary = true;
            this.btnAccept.Size = new System.Drawing.Size(68, 32);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // TradePopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 207);
            this.ControlBox = false;
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDesc);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TradePopupForm";
            this.Opacity = 0.95D;
            this.Text = "New confirmation";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TradePopupForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblDesc;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialLabel lblAccount;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeny;
        private MaterialSkin.Controls.MaterialRaisedButton btnAccept;
    }
}