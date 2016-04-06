namespace Steam_Desktop_Authenticator
{
    partial class InstallRedistribForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallRedistribForm));
            this.progressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.downloadStatus = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Depth = 0;
            this.progressBar1.Location = new System.Drawing.Point(12, 153);
            this.progressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 5);
            this.progressBar1.TabIndex = 1;
            // 
            // downloadStatus
            // 
            this.downloadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadStatus.Depth = 0;
            this.downloadStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.downloadStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.downloadStatus.Location = new System.Drawing.Point(12, 71);
            this.downloadStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadStatus.Name = "downloadStatus";
            this.downloadStatus.Size = new System.Drawing.Size(315, 79);
            this.downloadStatus.TabIndex = 2;
            this.downloadStatus.Text = "Downloading Visual C++ Redistributable 2013";
            // 
            // InstallRedistribForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 167);
            this.Controls.Add(this.downloadStatus);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InstallRedistribForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installing";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialProgressBar progressBar1;
        private MaterialSkin.Controls.MaterialLabel downloadStatus;
    }
}