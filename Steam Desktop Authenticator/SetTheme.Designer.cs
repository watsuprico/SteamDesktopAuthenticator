namespace Steam_Desktop_Authenticator
{
    partial class SetTheme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetTheme));
            this.btnQuit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNoTheme = new MaterialSkin.Controls.MaterialFlatButton();
            this.setThemeTime = new System.Windows.Forms.Timer(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.AutoSize = true;
            this.btnQuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuit.Depth = 0;
            this.btnQuit.Location = new System.Drawing.Point(286, 46);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Primary = false;
            this.btnQuit.Size = new System.Drawing.Size(43, 36);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnNoTheme
            // 
            this.btnNoTheme.AutoSize = true;
            this.btnNoTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNoTheme.Depth = 0;
            this.btnNoTheme.Location = new System.Drawing.Point(13, 51);
            this.btnNoTheme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNoTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNoTheme.Name = "btnNoTheme";
            this.btnNoTheme.Primary = false;
            this.btnNoTheme.Size = new System.Drawing.Size(80, 36);
            this.btnNoTheme.TabIndex = 2;
            this.btnNoTheme.Text = "No theme";
            this.btnNoTheme.UseVisualStyleBackColor = true;
            this.btnNoTheme.Click += new System.EventHandler(this.btnNoTheme_Click);
            // 
            // setThemeTime
            // 
            this.setThemeTime.Interval = 300;
            this.setThemeTime.Tick += new System.EventHandler(this.setThemeTime_Tick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(43, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(207, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Steam Desktop Authenticator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SetTheme
            // 
            this.AcceptButton = this.btnNoTheme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(342, 99);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnNoTheme);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetTheme";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Steam Desktop Authenticator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SetTheme_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnQuit;
        private MaterialSkin.Controls.MaterialFlatButton btnNoTheme;
        private System.Windows.Forms.Timer setThemeTime;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}