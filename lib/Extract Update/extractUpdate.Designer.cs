namespace Extract_Update
{
    partial class extractUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(extractUpdate));
            this.statusBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.extractTime = new System.Windows.Forms.Timer(this.components);
            this.fileNames = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(12, 132);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(354, 17);
            this.statusBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Extracting update";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconBox
            // 
            this.iconBox.Image = ((System.Drawing.Image)(resources.GetObject("iconBox.Image")));
            this.iconBox.Location = new System.Drawing.Point(112, 13);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(15, 15);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox.TabIndex = 3;
            this.iconBox.TabStop = false;
            // 
            // extractTime
            // 
            this.extractTime.Enabled = true;
            this.extractTime.Tick += new System.EventHandler(this.extractTime_Tick);
            // 
            // fileNames
            // 
            this.fileNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fileNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileNames.Location = new System.Drawing.Point(12, 35);
            this.fileNames.Name = "fileNames";
            this.fileNames.ReadOnly = true;
            this.fileNames.Size = new System.Drawing.Size(354, 91);
            this.fileNames.TabIndex = 4;
            this.fileNames.Text = "";
            this.fileNames.WordWrap = false;
            this.fileNames.TextChanged += new System.EventHandler(this.fileNames_TextChanged);
            // 
            // extractUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(378, 161);
            this.ControlBox = false;
            this.Controls.Add(this.fileNames);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "extractUpdate";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extracting SDA update";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.extractUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar statusBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Timer extractTime;
        private System.Windows.Forms.RichTextBox fileNames;
    }
}

