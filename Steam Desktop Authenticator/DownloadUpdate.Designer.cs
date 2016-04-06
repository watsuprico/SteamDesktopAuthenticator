namespace Steam_Desktop_Authenticator
{
    partial class DownloadUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadUpdate));
            this.statusBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.downloadStatus = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar.Depth = 0;
            this.statusBar.Location = new System.Drawing.Point(12, 134);
            this.statusBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(321, 5);
            this.statusBar.TabIndex = 0;
            // 
            // downloadStatus
            // 
            this.downloadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadStatus.Depth = 0;
            this.downloadStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.downloadStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.downloadStatus.Location = new System.Drawing.Point(12, 70);
            this.downloadStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadStatus.Name = "downloadStatus";
            this.downloadStatus.Size = new System.Drawing.Size(321, 61);
            this.downloadStatus.TabIndex = 1;
            // 
            // DownloadUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 154);
            this.Controls.Add(this.downloadStatus);
            this.Controls.Add(this.statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadUpdate";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloading Update";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialProgressBar statusBar;
        private MaterialSkin.Controls.MaterialLabel downloadStatus;
    }
}