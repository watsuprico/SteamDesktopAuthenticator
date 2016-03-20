namespace Steam_Desktop_Authenticator
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.btnAndroidImport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnJustStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnImportConfig = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnAndroidImport
            // 
            this.btnAndroidImport.Depth = 0;
            this.btnAndroidImport.Location = new System.Drawing.Point(12, 221);
            this.btnAndroidImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAndroidImport.Name = "btnAndroidImport";
            this.btnAndroidImport.Primary = true;
            this.btnAndroidImport.Size = new System.Drawing.Size(391, 50);
            this.btnAndroidImport.TabIndex = 5;
            this.btnAndroidImport.Text = "I want to import my Steam account(s) from the Steam app on my Android device.";
            this.btnAndroidImport.UseVisualStyleBackColor = true;
            this.btnAndroidImport.Click += new System.EventHandler(this.btnAndroidImport_Click);
            // 
            // btnJustStart
            // 
            this.btnJustStart.Depth = 0;
            this.btnJustStart.Location = new System.Drawing.Point(12, 166);
            this.btnJustStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnJustStart.Name = "btnJustStart";
            this.btnJustStart.Primary = true;
            this.btnJustStart.Size = new System.Drawing.Size(391, 50);
            this.btnJustStart.TabIndex = 6;
            this.btnJustStart.Text = "This is my first time and I just want to sign into my Steam Account(s).";
            this.btnJustStart.UseVisualStyleBackColor = true;
            this.btnJustStart.Click += new System.EventHandler(this.btnJustStart_Click);
            // 
            // btnImportConfig
            // 
            this.btnImportConfig.Depth = 0;
            this.btnImportConfig.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportConfig.Location = new System.Drawing.Point(12, 275);
            this.btnImportConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportConfig.Name = "btnImportConfig";
            this.btnImportConfig.Primary = true;
            this.btnImportConfig.Size = new System.Drawing.Size(391, 53);
            this.btnImportConfig.TabIndex = 7;
            this.btnImportConfig.Text = "I already setup the Authenticator program and I want to import the account(s).";
            this.btnImportConfig.UseVisualStyleBackColor = true;
            this.btnImportConfig.Click += new System.EventHandler(this.btnImportConfig_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 134);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(391, 27);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Select an item to get started:";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 69);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(391, 65);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Welcome to the Steam Desktop Authentication program";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeForm
            // 
            this.AcceptButton = this.btnJustStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 340);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnImportConfig);
            this.Controls.Add(this.btnJustStart);
            this.Controls.Add(this.btnAndroidImport);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Desktop Authenticator";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnAndroidImport;
        private MaterialSkin.Controls.MaterialRaisedButton btnJustStart;
        private MaterialSkin.Controls.MaterialRaisedButton btnImportConfig;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}