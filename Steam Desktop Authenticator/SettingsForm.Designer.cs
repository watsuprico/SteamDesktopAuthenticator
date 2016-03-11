namespace Steam_Desktop_Authenticator
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.numPeriodicInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.chkCheckAll = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkConfirmMarket = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkConfirmTrades = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkPeriodicChecking = new MaterialSkin.Controls.MaterialCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriodicInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // numPeriodicInterval
            // 
            this.numPeriodicInterval.Location = new System.Drawing.Point(12, 197);
            this.numPeriodicInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPeriodicInterval.Name = "numPeriodicInterval";
            this.numPeriodicInterval.Size = new System.Drawing.Size(41, 22);
            this.numPeriodicInterval.TabIndex = 2;
            this.numPeriodicInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(59, 190);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time between checking for confirmations (in seconds)";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(0, 247);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(299, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkCheckAll
            // 
            this.chkCheckAll.AutoSize = true;
            this.chkCheckAll.Depth = 0;
            this.chkCheckAll.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkCheckAll.Location = new System.Drawing.Point(9, 70);
            this.chkCheckAll.Margin = new System.Windows.Forms.Padding(0);
            this.chkCheckAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkCheckAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkCheckAll.Name = "chkCheckAll";
            this.chkCheckAll.Ripple = true;
            this.chkCheckAll.Size = new System.Drawing.Size(256, 30);
            this.chkCheckAll.TabIndex = 6;
            this.chkCheckAll.Text = "Check all accounts for confirmations";
            this.chkCheckAll.UseVisualStyleBackColor = true;
            // 
            // chkConfirmMarket
            // 
            this.chkConfirmMarket.AutoSize = true;
            this.chkConfirmMarket.Depth = 0;
            this.chkConfirmMarket.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkConfirmMarket.Location = new System.Drawing.Point(9, 100);
            this.chkConfirmMarket.Margin = new System.Windows.Forms.Padding(0);
            this.chkConfirmMarket.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkConfirmMarket.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkConfirmMarket.Name = "chkConfirmMarket";
            this.chkConfirmMarket.Ripple = true;
            this.chkConfirmMarket.Size = new System.Drawing.Size(238, 30);
            this.chkConfirmMarket.TabIndex = 5;
            this.chkConfirmMarket.Text = "Auto-confirm market transactions";
            this.chkConfirmMarket.UseVisualStyleBackColor = true;
            this.chkConfirmMarket.CheckedChanged += new System.EventHandler(this.chkConfirmMarket_CheckedChanged);
            // 
            // chkConfirmTrades
            // 
            this.chkConfirmTrades.AutoSize = true;
            this.chkConfirmTrades.Depth = 0;
            this.chkConfirmTrades.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkConfirmTrades.Location = new System.Drawing.Point(9, 130);
            this.chkConfirmTrades.Margin = new System.Windows.Forms.Padding(0);
            this.chkConfirmTrades.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkConfirmTrades.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkConfirmTrades.Name = "chkConfirmTrades";
            this.chkConfirmTrades.Ripple = true;
            this.chkConfirmTrades.Size = new System.Drawing.Size(154, 30);
            this.chkConfirmTrades.TabIndex = 6;
            this.chkConfirmTrades.Text = "Auto-confirm trades";
            this.chkConfirmTrades.UseVisualStyleBackColor = true;
            this.chkConfirmTrades.CheckedChanged += new System.EventHandler(this.chkConfirmTrades_CheckedChanged);
            // 
            // chkPeriodicChecking
            // 
            this.chkPeriodicChecking.AutoSize = true;
            this.chkPeriodicChecking.Depth = 0;
            this.chkPeriodicChecking.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkPeriodicChecking.Location = new System.Drawing.Point(9, 160);
            this.chkPeriodicChecking.Margin = new System.Windows.Forms.Padding(0);
            this.chkPeriodicChecking.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkPeriodicChecking.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkPeriodicChecking.Name = "chkPeriodicChecking";
            this.chkPeriodicChecking.Ripple = true;
            this.chkPeriodicChecking.Size = new System.Drawing.Size(280, 30);
            this.chkPeriodicChecking.TabIndex = 7;
            this.chkPeriodicChecking.Text = "Periodically check for new confirmations\r\nand show a popup when they arrive";
            this.chkPeriodicChecking.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 283);
            this.Controls.Add(this.chkConfirmTrades);
            this.Controls.Add(this.chkConfirmMarket);
            this.Controls.Add(this.chkPeriodicChecking);
            this.Controls.Add(this.chkCheckAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPeriodicInterval);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numPeriodicInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numPeriodicInterval;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private MaterialSkin.Controls.MaterialCheckBox chkCheckAll;
        private MaterialSkin.Controls.MaterialCheckBox chkPeriodicChecking;
        private MaterialSkin.Controls.MaterialCheckBox chkConfirmMarket;
        private MaterialSkin.Controls.MaterialCheckBox chkConfirmTrades;
    }
}