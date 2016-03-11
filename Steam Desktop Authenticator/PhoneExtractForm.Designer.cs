namespace Steam_Desktop_Authenticator
{
    partial class PhoneExtractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneExtractForm));
            this.lblLog = new System.Windows.Forms.ListBox();
            this.btnConnect = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCheck = new MaterialSkin.Controls.MaterialFlatButton();
            this.tCheckDevice = new System.Windows.Forms.Timer(this.components);
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblLog
            // 
            this.lblLog.FormattingEnabled = true;
            this.lblLog.Location = new System.Drawing.Point(12, 240);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(445, 147);
            this.lblLog.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Depth = 0;
            this.btnConnect.Location = new System.Drawing.Point(15, 395);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = false;
            this.btnConnect.Size = new System.Drawing.Size(195, 36);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect to ADB over WiFi";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheck.Depth = 0;
            this.btnCheck.Location = new System.Drawing.Point(218, 395);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Primary = false;
            this.btnCheck.Size = new System.Drawing.Size(106, 36);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check device";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tCheckDevice
            // 
            this.tCheckDevice.Enabled = true;
            this.tCheckDevice.Interval = 5000;
            this.tCheckDevice.Tick += new System.EventHandler(this.tCheckDevice_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(11, 69);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Instructions:";
            // 
            // label2
            // 
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 115);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(11, 217);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log:";
            // 
            // PhoneExtractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblLog);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "PhoneExtractForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import from Android device";
            this.Load += new System.EventHandler(this.PhoneExtractForm_Load);
            this.Shown += new System.EventHandler(this.PhoneExtractForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblLog;
        private MaterialSkin.Controls.MaterialFlatButton btnConnect;
        private MaterialSkin.Controls.MaterialFlatButton btnCheck;
        private System.Windows.Forms.Timer tCheckDevice;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label3;
    }
}