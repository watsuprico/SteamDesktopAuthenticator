namespace Steam_Desktop_Authenticator
{

    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listAccounts = new System.Windows.Forms.ListBox();
            this.timerSteamGuard = new System.Windows.Forms.Timer(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStripTray = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.trayRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trayAccountList = new System.Windows.Forms.ToolStripComboBox();
            this.trayTradeConfirmations = new System.Windows.Forms.ToolStripMenuItem();
            this.trayCopySteamGuard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.trayQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTradesPopup = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.pbTimeout = new MaterialSkin.Controls.MaterialProgressBar();
            this.btnCopy = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtAccount = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.btnTradeConfirmations = new MaterialSkin.Controls.MaterialFlatButton();
            this.updateButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAccSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportMaFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportAndroid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManageEncryption = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openThemeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoginAgain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefreshSession = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRemoveAccountFromManifest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeactivateAuthenticator = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLoginToken = new MaterialSkin.Controls.MaterialLabel();
            this.menuStripTray.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAccounts
            // 
            this.listAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAccounts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAccounts.FormattingEnabled = true;
            this.listAccounts.Location = new System.Drawing.Point(12, 141);
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.Size = new System.Drawing.Size(441, 195);
            this.listAccounts.TabIndex = 3;
            this.listAccounts.SelectedValueChanged += new System.EventHandler(this.listAccounts_SelectedValueChanged);
            this.listAccounts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listAccounts_KeyDown);
            // 
            // timerSteamGuard
            // 
            this.timerSteamGuard.Enabled = true;
            this.timerSteamGuard.Interval = 1000;
            this.timerSteamGuard.Tick += new System.EventHandler(this.timerSteamGuard_Tick);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.menuStripTray;
            this.trayIcon.Text = "Steam Desktop Authenticator";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // menuStripTray
            // 
            this.menuStripTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStripTray.Depth = 0;
            this.menuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayRestore,
            this.toolStripSeparator2,
            this.trayAccountList,
            this.trayTradeConfirmations,
            this.trayCopySteamGuard,
            this.toolStripSeparator3,
            this.trayQuit});
            this.menuStripTray.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuStripTray.Name = "contextMenuStripTray";
            this.menuStripTray.Size = new System.Drawing.Size(216, 131);
            // 
            // trayRestore
            // 
            this.trayRestore.Name = "trayRestore";
            this.trayRestore.Size = new System.Drawing.Size(215, 22);
            this.trayRestore.Text = "Restore";
            this.trayRestore.Click += new System.EventHandler(this.trayRestore_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(212, 6);
            // 
            // trayAccountList
            // 
            this.trayAccountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trayAccountList.Items.AddRange(new object[] {
            "test1",
            "test2"});
            this.trayAccountList.Name = "trayAccountList";
            this.trayAccountList.Size = new System.Drawing.Size(121, 23);
            this.trayAccountList.SelectedIndexChanged += new System.EventHandler(this.trayAccountList_SelectedIndexChanged);
            // 
            // trayTradeConfirmations
            // 
            this.trayTradeConfirmations.Name = "trayTradeConfirmations";
            this.trayTradeConfirmations.Size = new System.Drawing.Size(215, 22);
            this.trayTradeConfirmations.Text = "Trade Confirmations";
            this.trayTradeConfirmations.Click += new System.EventHandler(this.trayTradeConfirmations_Click);
            // 
            // trayCopySteamGuard
            // 
            this.trayCopySteamGuard.Name = "trayCopySteamGuard";
            this.trayCopySteamGuard.Size = new System.Drawing.Size(215, 22);
            this.trayCopySteamGuard.Text = "Copy SG code to clipboard";
            this.trayCopySteamGuard.Click += new System.EventHandler(this.trayCopySteamGuard_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(212, 6);
            // 
            // trayQuit
            // 
            this.trayQuit.Name = "trayQuit";
            this.trayQuit.Size = new System.Drawing.Size(215, 22);
            this.trayQuit.Text = "Quit";
            this.trayQuit.Click += new System.EventHandler(this.trayQuit_Click);
            // 
            // timerTradesPopup
            // 
            this.timerTradesPopup.Enabled = true;
            this.timerTradesPopup.Interval = 5000;
            this.timerTradesPopup.Tick += new System.EventHandler(this.timerTradesPopup_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(244, 0);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(221, 24);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbTimeout
            // 
            this.pbTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTimeout.Depth = 0;
            this.pbTimeout.Location = new System.Drawing.Point(6, 64);
            this.pbTimeout.Maximum = 30;
            this.pbTimeout.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbTimeout.Name = "pbTimeout";
            this.pbTimeout.Size = new System.Drawing.Size(447, 5);
            this.pbTimeout.TabIndex = 1;
            this.pbTimeout.Value = 30;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Depth = 0;
            this.btnCopy.Location = new System.Drawing.Point(399, 35);
            this.btnCopy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Primary = true;
            this.btnCopy.Size = new System.Drawing.Size(54, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccount.Depth = 0;
            this.txtAccount.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAccount.Location = new System.Drawing.Point(2, 8);
            this.txtAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(457, 24);
            this.txtAccount.TabIndex = 14;
            this.txtAccount.Text = "Account";
            this.txtAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLoginToken);
            this.panel1.Controls.Add(this.statusBar);
            this.panel1.Controls.Add(this.btnTradeConfirmations);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Controls.Add(this.pbTimeout);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 110);
            this.panel1.TabIndex = 15;
            // 
            // statusBar
            // 
            this.statusBar.Depth = 0;
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusBar.Location = new System.Drawing.Point(0, 0);
            this.statusBar.MarqueeAnimationSpeed = 5;
            this.statusBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(465, 5);
            this.statusBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.statusBar.TabIndex = 16;
            // 
            // btnTradeConfirmations
            // 
            this.btnTradeConfirmations.AutoSize = true;
            this.btnTradeConfirmations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTradeConfirmations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTradeConfirmations.Depth = 0;
            this.btnTradeConfirmations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTradeConfirmations.Enabled = false;
            this.btnTradeConfirmations.Location = new System.Drawing.Point(0, 74);
            this.btnTradeConfirmations.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTradeConfirmations.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTradeConfirmations.Name = "btnTradeConfirmations";
            this.btnTradeConfirmations.Primary = false;
            this.btnTradeConfirmations.Size = new System.Drawing.Size(465, 36);
            this.btnTradeConfirmations.TabIndex = 15;
            this.btnTradeConfirmations.Text = "Trade Confirmations";
            this.btnTradeConfirmations.UseVisualStyleBackColor = true;
            this.btnTradeConfirmations.Click += new System.EventHandler(this.btnTradeConfirmations_Click);
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Depth = 0;
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Silver;
            this.updateButton.Location = new System.Drawing.Point(0, 25);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.Primary = false;
            this.updateButton.Size = new System.Drawing.Size(465, 36);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Update";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButtonClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAccSearch);
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 61);
            this.panel2.TabIndex = 17;
            // 
            // txtAccSearch
            // 
            this.txtAccSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccSearch.Depth = 0;
            this.txtAccSearch.Hint = "Search for an account";
            this.txtAccSearch.Location = new System.Drawing.Point(59, 3);
            this.txtAccSearch.MaxLength = 32767;
            this.txtAccSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAccSearch.Name = "txtAccSearch";
            this.txtAccSearch.PasswordChar = '\0';
            this.txtAccSearch.SelectedText = "";
            this.txtAccSearch.SelectionLength = 0;
            this.txtAccSearch.SelectionStart = 0;
            this.txtAccSearch.Size = new System.Drawing.Size(394, 23);
            this.txtAccSearch.TabIndex = 12;
            this.txtAccSearch.TabStop = false;
            this.txtAccSearch.UseSystemPasswordChar = false;
            this.txtAccSearch.TextChanged += new System.EventHandler(this.txtAccSearch_TextChanged);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.importAccountToolStripMenuItem,
            this.toolStripSeparator5,
            this.menuSettings,
            this.toolStripSeparator1,
            this.menuQuit});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newAccountToolStripMenuItem.Text = "New account";
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.btnSteamLogin_Click);
            // 
            // importAccountToolStripMenuItem
            // 
            this.importAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImportMaFile,
            this.menuImportAndroid});
            this.importAccountToolStripMenuItem.Name = "importAccountToolStripMenuItem";
            this.importAccountToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.importAccountToolStripMenuItem.Text = "Import Account";
            // 
            // menuImportMaFile
            // 
            this.menuImportMaFile.Name = "menuImportMaFile";
            this.menuImportMaFile.Size = new System.Drawing.Size(186, 22);
            this.menuImportMaFile.Text = "From maFile";
            this.menuImportMaFile.Click += new System.EventHandler(this.menuImportMaFile_Click);
            // 
            // menuImportAndroid
            // 
            this.menuImportAndroid.Name = "menuImportAndroid";
            this.menuImportAndroid.Size = new System.Drawing.Size(186, 22);
            this.menuImportAndroid.Text = "From Android Device";
            this.menuImportAndroid.Click += new System.EventHandler(this.menuImportAndroid_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // menuSettings
            // 
            this.menuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnManageEncryption,
            this.openSettingsWindowToolStripMenuItem,
            this.openThemeWindowToolStripMenuItem});
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(158, 22);
            this.menuSettings.Text = "Settings";
            // 
            // btnManageEncryption
            // 
            this.btnManageEncryption.Name = "btnManageEncryption";
            this.btnManageEncryption.Size = new System.Drawing.Size(195, 22);
            this.btnManageEncryption.Text = "Manage Encryption";
            this.btnManageEncryption.Click += new System.EventHandler(this.btnManageEncryption_Click);
            // 
            // openSettingsWindowToolStripMenuItem
            // 
            this.openSettingsWindowToolStripMenuItem.Name = "openSettingsWindowToolStripMenuItem";
            this.openSettingsWindowToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openSettingsWindowToolStripMenuItem.Text = "Open Settings Window";
            this.openSettingsWindowToolStripMenuItem.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // openThemeWindowToolStripMenuItem
            // 
            this.openThemeWindowToolStripMenuItem.Name = "openThemeWindowToolStripMenuItem";
            this.openThemeWindowToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openThemeWindowToolStripMenuItem.Text = "Open Theme Window";
            this.openThemeWindowToolStripMenuItem.Click += new System.EventHandler(this.openThemeWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(158, 22);
            this.menuQuit.Text = "Quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoginAgain,
            this.menuRefreshSession,
            this.toolStripSeparator4,
            this.menuRemoveAccountFromManifest,
            this.menuDeactivateAuthenticator});
            this.accountToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.accountToolStripMenuItem.Text = "Selected Account";
            // 
            // menuLoginAgain
            // 
            this.menuLoginAgain.Name = "menuLoginAgain";
            this.menuLoginAgain.Size = new System.Drawing.Size(205, 22);
            this.menuLoginAgain.Text = "Login again";
            this.menuLoginAgain.Click += new System.EventHandler(this.menuLoginAgain_Click);
            // 
            // menuRefreshSession
            // 
            this.menuRefreshSession.Name = "menuRefreshSession";
            this.menuRefreshSession.Size = new System.Drawing.Size(205, 22);
            this.menuRefreshSession.Text = "Force session refresh";
            this.menuRefreshSession.Click += new System.EventHandler(this.menuRefreshSession_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(202, 6);
            // 
            // menuRemoveAccountFromManifest
            // 
            this.menuRemoveAccountFromManifest.Name = "menuRemoveAccountFromManifest";
            this.menuRemoveAccountFromManifest.Size = new System.Drawing.Size(205, 22);
            this.menuRemoveAccountFromManifest.Text = "Remove from manifest";
            this.menuRemoveAccountFromManifest.Click += new System.EventHandler(this.menuRemoveAccountFromManifest_Click);
            // 
            // menuDeactivateAuthenticator
            // 
            this.menuDeactivateAuthenticator.Name = "menuDeactivateAuthenticator";
            this.menuDeactivateAuthenticator.Size = new System.Drawing.Size(205, 22);
            this.menuDeactivateAuthenticator.Text = "Deactivate Authenticator";
            this.menuDeactivateAuthenticator.Click += new System.EventHandler(this.menuDeactivateAuthenticator_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(465, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.listAccounts);
            this.panel3.Controls.Add(this.menuStrip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 413);
            this.panel3.TabIndex = 18;
            // 
            // txtLoginToken
            // 
            this.txtLoginToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginToken.Depth = 0;
            this.txtLoginToken.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLoginToken.Location = new System.Drawing.Point(6, 35);
            this.txtLoginToken.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLoginToken.Name = "txtLoginToken";
            this.txtLoginToken.Size = new System.Drawing.Size(387, 26);
            this.txtLoginToken.TabIndex = 17;
            this.txtLoginToken.Text = "No auth code available";
            this.txtLoginToken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCopy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 476);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Desktop Authenticator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStripTray.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listAccounts;
        private System.Windows.Forms.Timer timerSteamGuard;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private MaterialSkin.Controls.MaterialContextMenuStrip menuStripTray;
        private System.Windows.Forms.ToolStripMenuItem trayRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem trayTradeConfirmations;
        private System.Windows.Forms.ToolStripMenuItem trayCopySteamGuard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem trayQuit;
        private System.Windows.Forms.Timer timerTradesPopup;
        private System.Windows.Forms.ToolStripComboBox trayAccountList;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialProgressBar pbTimeout;
        private MaterialSkin.Controls.MaterialRaisedButton btnCopy;
        private MaterialSkin.Controls.MaterialLabel txtAccount;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton updateButton;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAccSearch;
        private MaterialSkin.Controls.MaterialFlatButton btnTradeConfirmations;
        private MaterialSkin.Controls.MaterialProgressBar statusBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuImportMaFile;
        private System.Windows.Forms.ToolStripMenuItem menuImportAndroid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem btnManageEncryption;
        private System.Windows.Forms.ToolStripMenuItem openSettingsWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLoginAgain;
        private System.Windows.Forms.ToolStripMenuItem menuRefreshSession;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveAccountFromManifest;
        private System.Windows.Forms.ToolStripMenuItem menuDeactivateAuthenticator;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem openThemeWindowToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel txtLoginToken;
    }
}

