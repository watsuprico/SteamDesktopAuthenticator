namespace Steam_Desktop_Authenticator
{
    partial class ThemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeForm));
            this.lstP = new System.Windows.Forms.ListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lstPDark = new System.Windows.Forms.ListBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lstPLight = new System.Windows.Forms.ListBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDarkMode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLightMode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSaveAndQuit = new MaterialSkin.Controls.MaterialFlatButton();
            this.savedStatus = new MaterialSkin.Controls.MaterialLabel();
            this.btnLoadTheme = new MaterialSkin.Controls.MaterialFlatButton();
            this.ThemeRGBTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrimaryCLAlpha = new System.Windows.Forms.NumericUpDown();
            this.BackgroundCAlpha = new System.Windows.Forms.NumericUpDown();
            this.PrimaryCDAlpha = new System.Windows.Forms.NumericUpDown();
            this.AccentCAlpha = new System.Windows.Forms.NumericUpDown();
            this.PrimaryCAlpha = new System.Windows.Forms.NumericUpDown();
            this.chkCustomBackgrounds = new MaterialSkin.Controls.MaterialCheckBox();
            this.panBackground = new System.Windows.Forms.Panel();
            this.panPrimaryAccent = new System.Windows.Forms.Panel();
            this.panPrimaryLight = new System.Windows.Forms.Panel();
            this.panPrimary = new System.Windows.Forms.Panel();
            this.panPrimaryDark = new System.Windows.Forms.Panel();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lblBackgroundColor = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.ThemeRGBTabsS = new MaterialSkin.Controls.MaterialTabSelector();
            this.PrimaryCD = new System.Windows.Forms.ColorDialog();
            this.PrimaryDCD = new System.Windows.Forms.ColorDialog();
            this.PrimaryLCD = new System.Windows.Forms.ColorDialog();
            this.AccentCD = new System.Windows.Forms.ColorDialog();
            this.BackgroundCD = new System.Windows.Forms.ColorDialog();
            this.lblRGBMode = new MaterialSkin.Controls.MaterialLabel();
            this.lblSpecial = new MaterialSkin.Controls.MaterialLabel();
            this.chkDynamicOtherBackgrounds = new MaterialSkin.Controls.MaterialCheckBox();
            this.OtherBackgroundsCD = new System.Windows.Forms.ColorDialog();
            this.btnChangeOtherBackground = new MaterialSkin.Controls.MaterialFlatButton();
            this.OtherBackgroundsExample = new System.Windows.Forms.Panel();
            this.ThemeRGBTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryCLAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundCAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryCDAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccentCAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryCAlpha)).BeginInit();
            this.OtherBackgroundsExample.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstP
            // 
            this.lstP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstP.FormattingEnabled = true;
            this.lstP.Items.AddRange(new object[] {
            "Red50",
            "Red100",
            "Red200",
            "Red300",
            "Red400",
            "Red500",
            "Red600",
            "Red700",
            "Red800",
            "Red900",
            "Pink50",
            "Pink100",
            "Pink200",
            "Pink300",
            "Pink400",
            "Pink500",
            "Pink600",
            "Pink700",
            "Pink800",
            "Pink900",
            "Purple50",
            "Purple100",
            "Purple200",
            "Purple300",
            "Purple400",
            "Purple500",
            "Purple600",
            "Purple700",
            "Purple800",
            "Purple900",
            "DeepPurple50",
            "DeepPurple100",
            "DeepPurple200",
            "DeepPurple300",
            "DeepPurple400",
            "DeepPurple500",
            "DeepPurple600",
            "DeepPurple700",
            "DeepPurple800",
            "DeepPurple900",
            "Indigo50",
            "Indigo100",
            "Indigo200",
            "Indigo300",
            "Indigo400",
            "Indigo500",
            "Indigo600",
            "Indigo700",
            "Indigo800",
            "Indigo900",
            "Blue50",
            "Blue100",
            "Blue200",
            "Blue300",
            "Blue400",
            "Blue500",
            "Blue600",
            "Blue700",
            "Blue800",
            "Blue900",
            "LightBlue50",
            "LightBlue100",
            "LightBlue200",
            "LightBlue300",
            "LightBlue400",
            "LightBlue500",
            "LightBlue600",
            "LightBlue700",
            "LightBlue800",
            "LightBlue900",
            "Cyan50",
            "Cyan100",
            "Cyan200",
            "Cyan300",
            "Cyan400",
            "Cyan500",
            "Cyan600",
            "Cyan700",
            "Cyan800",
            "Cyan900",
            "Teal50",
            "Teal100",
            "Teal200",
            "Teal300",
            "Teal400",
            "Teal500",
            "Teal600",
            "Teal700",
            "Teal800",
            "Teal900",
            "Green50",
            "Green100",
            "Green200",
            "Green300",
            "Green400",
            "Green500",
            "Green600",
            "Green700",
            "Green800",
            "Green900",
            "LightGreen50",
            "LightGreen100",
            "LightGreen200",
            "LightGreen300",
            "LightGreen400",
            "LightGreen500",
            "LightGreen600",
            "LightGreen700",
            "LightGreen800",
            "LightGreen900",
            "Lime50",
            "Lime100",
            "Lime200",
            "Lime300",
            "Lime400",
            "Lime500",
            "Lime600",
            "Lime700",
            "Lime800",
            "Lime900",
            "Yellow50",
            "Yellow100",
            "Yellow200",
            "Yellow300",
            "Yellow400",
            "Yellow500",
            "Yellow600",
            "Yellow700",
            "Yellow800",
            "Yellow900",
            "Amber50",
            "Amber100",
            "Amber200",
            "Amber300",
            "Amber400",
            "Amber500",
            "Amber600",
            "Amber700",
            "Amber800",
            "Amber900",
            "Orange50",
            "Orange100",
            "Orange200",
            "Orange300",
            "Orange400",
            "Orange500",
            "Orange600",
            "Orange700",
            "Orange800",
            "Orange900",
            "DeepOrange50",
            "DeepOrange100",
            "DeepOrange200",
            "DeepOrange300",
            "DeepOrange400",
            "DeepOrange500",
            "DeepOrange600",
            "DeepOrange700",
            "DeepOrange800",
            "DeepOrange900",
            "Brown50",
            "Brown100",
            "Brown200",
            "Brown300",
            "Brown400",
            "Brown500",
            "Brown600",
            "Brown700",
            "Brown800",
            "Brown900",
            "Grey50",
            "Grey100",
            "Grey200",
            "Grey300",
            "Grey400",
            "Grey500",
            "Grey600",
            "Grey700",
            "Grey800",
            "Grey900",
            "BlueGrey50",
            "BlueGrey100",
            "BlueGrey200",
            "BlueGrey300",
            "BlueGrey400",
            "BlueGrey500",
            "BlueGrey600",
            "BlueGrey700",
            "BlueGrey800",
            "BlueGrey900"});
            this.lstP.Location = new System.Drawing.Point(6, 30);
            this.lstP.Name = "lstP";
            this.lstP.Size = new System.Drawing.Size(158, 108);
            this.lstP.TabIndex = 0;
            this.lstP.SelectedValueChanged += new System.EventHandler(this.lstP_SelectedValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(53, 8);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Primary";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(235, 8);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(95, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Primary Dark";
            // 
            // lstPDark
            // 
            this.lstPDark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPDark.FormattingEnabled = true;
            this.lstPDark.Items.AddRange(new object[] {
            "Red50",
            "Red100",
            "Red200",
            "Red300",
            "Red400",
            "Red500",
            "Red600",
            "Red700",
            "Red800",
            "Red900",
            "Pink50",
            "Pink100",
            "Pink200",
            "Pink300",
            "Pink400",
            "Pink500",
            "Pink600",
            "Pink700",
            "Pink800",
            "Pink900",
            "Purple50",
            "Purple100",
            "Purple200",
            "Purple300",
            "Purple400",
            "Purple500",
            "Purple600",
            "Purple700",
            "Purple800",
            "Purple900",
            "DeepPurple50",
            "DeepPurple100",
            "DeepPurple200",
            "DeepPurple300",
            "DeepPurple400",
            "DeepPurple500",
            "DeepPurple600",
            "DeepPurple700",
            "DeepPurple800",
            "DeepPurple900",
            "Indigo50",
            "Indigo100",
            "Indigo200",
            "Indigo300",
            "Indigo400",
            "Indigo500",
            "Indigo600",
            "Indigo700",
            "Indigo800",
            "Indigo900",
            "Blue50",
            "Blue100",
            "Blue200",
            "Blue300",
            "Blue400",
            "Blue500",
            "Blue600",
            "Blue700",
            "Blue800",
            "Blue900",
            "LightBlue50",
            "LightBlue100",
            "LightBlue200",
            "LightBlue300",
            "LightBlue400",
            "LightBlue500",
            "LightBlue600",
            "LightBlue700",
            "LightBlue800",
            "LightBlue900",
            "Cyan50",
            "Cyan100",
            "Cyan200",
            "Cyan300",
            "Cyan400",
            "Cyan500",
            "Cyan600",
            "Cyan700",
            "Cyan800",
            "Cyan900",
            "Teal50",
            "Teal100",
            "Teal200",
            "Teal300",
            "Teal400",
            "Teal500",
            "Teal600",
            "Teal700",
            "Teal800",
            "Teal900",
            "Green50",
            "Green100",
            "Green200",
            "Green300",
            "Green400",
            "Green500",
            "Green600",
            "Green700",
            "Green800",
            "Green900",
            "LightGreen50",
            "LightGreen100",
            "LightGreen200",
            "LightGreen300",
            "LightGreen400",
            "LightGreen500",
            "LightGreen600",
            "LightGreen700",
            "LightGreen800",
            "LightGreen900",
            "Lime50",
            "Lime100",
            "Lime200",
            "Lime300",
            "Lime400",
            "Lime500",
            "Lime600",
            "Lime700",
            "Lime800",
            "Lime900",
            "Yellow50",
            "Yellow100",
            "Yellow200",
            "Yellow300",
            "Yellow400",
            "Yellow500",
            "Yellow600",
            "Yellow700",
            "Yellow800",
            "Yellow900",
            "Amber50",
            "Amber100",
            "Amber200",
            "Amber300",
            "Amber400",
            "Amber500",
            "Amber600",
            "Amber700",
            "Amber800",
            "Amber900",
            "Orange50",
            "Orange100",
            "Orange200",
            "Orange300",
            "Orange400",
            "Orange500",
            "Orange600",
            "Orange700",
            "Orange800",
            "Orange900",
            "DeepOrange50",
            "DeepOrange100",
            "DeepOrange200",
            "DeepOrange300",
            "DeepOrange400",
            "DeepOrange500",
            "DeepOrange600",
            "DeepOrange700",
            "DeepOrange800",
            "DeepOrange900",
            "Brown50",
            "Brown100",
            "Brown200",
            "Brown300",
            "Brown400",
            "Brown500",
            "Brown600",
            "Brown700",
            "Brown800",
            "Brown900",
            "Grey50",
            "Grey100",
            "Grey200",
            "Grey300",
            "Grey400",
            "Grey500",
            "Grey600",
            "Grey700",
            "Grey800",
            "Grey900",
            "BlueGrey50",
            "BlueGrey100",
            "BlueGrey200",
            "BlueGrey300",
            "BlueGrey400",
            "BlueGrey500",
            "BlueGrey600",
            "BlueGrey700",
            "BlueGrey800",
            "BlueGrey900"});
            this.lstPDark.Location = new System.Drawing.Point(205, 30);
            this.lstPDark.Name = "lstPDark";
            this.lstPDark.Size = new System.Drawing.Size(158, 108);
            this.lstPDark.TabIndex = 2;
            this.lstPDark.SelectedValueChanged += new System.EventHandler(this.lstP_SelectedValueChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(31, 150);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(97, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Primary Light";
            // 
            // lstPLight
            // 
            this.lstPLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPLight.FormattingEnabled = true;
            this.lstPLight.Items.AddRange(new object[] {
            "Red50",
            "Red100",
            "Red200",
            "Red300",
            "Red400",
            "Red500",
            "Red600",
            "Red700",
            "Red800",
            "Red900",
            "Pink50",
            "Pink100",
            "Pink200",
            "Pink300",
            "Pink400",
            "Pink500",
            "Pink600",
            "Pink700",
            "Pink800",
            "Pink900",
            "Purple50",
            "Purple100",
            "Purple200",
            "Purple300",
            "Purple400",
            "Purple500",
            "Purple600",
            "Purple700",
            "Purple800",
            "Purple900",
            "DeepPurple50",
            "DeepPurple100",
            "DeepPurple200",
            "DeepPurple300",
            "DeepPurple400",
            "DeepPurple500",
            "DeepPurple600",
            "DeepPurple700",
            "DeepPurple800",
            "DeepPurple900",
            "Indigo50",
            "Indigo100",
            "Indigo200",
            "Indigo300",
            "Indigo400",
            "Indigo500",
            "Indigo600",
            "Indigo700",
            "Indigo800",
            "Indigo900",
            "Blue50",
            "Blue100",
            "Blue200",
            "Blue300",
            "Blue400",
            "Blue500",
            "Blue600",
            "Blue700",
            "Blue800",
            "Blue900",
            "LightBlue50",
            "LightBlue100",
            "LightBlue200",
            "LightBlue300",
            "LightBlue400",
            "LightBlue500",
            "LightBlue600",
            "LightBlue700",
            "LightBlue800",
            "LightBlue900",
            "Cyan50",
            "Cyan100",
            "Cyan200",
            "Cyan300",
            "Cyan400",
            "Cyan500",
            "Cyan600",
            "Cyan700",
            "Cyan800",
            "Cyan900",
            "Teal50",
            "Teal100",
            "Teal200",
            "Teal300",
            "Teal400",
            "Teal500",
            "Teal600",
            "Teal700",
            "Teal800",
            "Teal900",
            "Green50",
            "Green100",
            "Green200",
            "Green300",
            "Green400",
            "Green500",
            "Green600",
            "Green700",
            "Green800",
            "Green900",
            "LightGreen50",
            "LightGreen100",
            "LightGreen200",
            "LightGreen300",
            "LightGreen400",
            "LightGreen500",
            "LightGreen600",
            "LightGreen700",
            "LightGreen800",
            "LightGreen900",
            "Lime50",
            "Lime100",
            "Lime200",
            "Lime300",
            "Lime400",
            "Lime500",
            "Lime600",
            "Lime700",
            "Lime800",
            "Lime900",
            "Yellow50",
            "Yellow100",
            "Yellow200",
            "Yellow300",
            "Yellow400",
            "Yellow500",
            "Yellow600",
            "Yellow700",
            "Yellow800",
            "Yellow900",
            "Amber50",
            "Amber100",
            "Amber200",
            "Amber300",
            "Amber400",
            "Amber500",
            "Amber600",
            "Amber700",
            "Amber800",
            "Amber900",
            "Orange50",
            "Orange100",
            "Orange200",
            "Orange300",
            "Orange400",
            "Orange500",
            "Orange600",
            "Orange700",
            "Orange800",
            "Orange900",
            "DeepOrange50",
            "DeepOrange100",
            "DeepOrange200",
            "DeepOrange300",
            "DeepOrange400",
            "DeepOrange500",
            "DeepOrange600",
            "DeepOrange700",
            "DeepOrange800",
            "DeepOrange900",
            "Brown50",
            "Brown100",
            "Brown200",
            "Brown300",
            "Brown400",
            "Brown500",
            "Brown600",
            "Brown700",
            "Brown800",
            "Brown900",
            "Grey50",
            "Grey100",
            "Grey200",
            "Grey300",
            "Grey400",
            "Grey500",
            "Grey600",
            "Grey700",
            "Grey800",
            "Grey900",
            "BlueGrey50",
            "BlueGrey100",
            "BlueGrey200",
            "BlueGrey300",
            "BlueGrey400",
            "BlueGrey500",
            "BlueGrey600",
            "BlueGrey700",
            "BlueGrey800",
            "BlueGrey900"});
            this.lstPLight.Location = new System.Drawing.Point(6, 172);
            this.lstPLight.Name = "lstPLight";
            this.lstPLight.Size = new System.Drawing.Size(158, 108);
            this.lstPLight.TabIndex = 4;
            this.lstPLight.SelectedValueChanged += new System.EventHandler(this.lstP_SelectedValueChanged);
            // 
            // lstA
            // 
            this.lstA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstA.FormattingEnabled = true;
            this.lstA.Items.AddRange(new object[] {
            "Red100",
            "Red200",
            "Red400",
            "Red700",
            "Pink100",
            "Pink200",
            "Pink400",
            "Pink700",
            "Purple100",
            "Purple200",
            "Purple400",
            "Purple700",
            "DeepPurple100",
            "DeepPurple200",
            "DeepPurple400",
            "DeepPurple700",
            "Indigo100",
            "Indigo200",
            "Indigo400",
            "Indigo700",
            "Blue100",
            "Blue200",
            "Blue400",
            "Blue700",
            "LightBlue100",
            "LightBlue200",
            "LightBlue400",
            "LightBlue700",
            "Cyan100",
            "Cyan200",
            "Cyan400",
            "Cyan700",
            "Teal100",
            "Teal200",
            "Teal400",
            "Teal700",
            "Green100",
            "Green200",
            "Green400",
            "Green700",
            "LightGreen100",
            "LightGreen200",
            "LightGreen400",
            "LightGreen700",
            "Lime100",
            "Lime200",
            "Lime400",
            "Lime700",
            "Yellow100",
            "Yellow200",
            "Yellow400",
            "Yellow700",
            "Amber100",
            "Amber200",
            "Amber400",
            "Amber700",
            "Orange100",
            "Orange200",
            "Orange400",
            "Orange700",
            "DeepOrange100",
            "DeepOrange200",
            "DeepOrange400",
            "DeepOrange700",
            "Grey50",
            "Grey100",
            "Grey200",
            "Grey300",
            "Grey400",
            "Grey500",
            "Grey600",
            "Grey700",
            "Grey800",
            "Grey900"});
            this.lstA.Location = new System.Drawing.Point(205, 172);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(158, 108);
            this.lstA.TabIndex = 6;
            this.lstA.SelectedValueChanged += new System.EventHandler(this.lstP_SelectedValueChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(254, 150);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(56, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Accent";
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.BackColor = System.Drawing.Color.Transparent;
            this.btnDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarkMode.Depth = 0;
            this.btnDarkMode.Location = new System.Drawing.Point(412, 211);
            this.btnDarkMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Primary = true;
            this.btnDarkMode.Size = new System.Drawing.Size(111, 29);
            this.btnDarkMode.TabIndex = 8;
            this.btnDarkMode.Text = "Dark mode";
            this.btnDarkMode.UseVisualStyleBackColor = false;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // btnLightMode
            // 
            this.btnLightMode.BackColor = System.Drawing.Color.Transparent;
            this.btnLightMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightMode.Depth = 0;
            this.btnLightMode.Location = new System.Drawing.Point(529, 211);
            this.btnLightMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLightMode.Name = "btnLightMode";
            this.btnLightMode.Primary = true;
            this.btnLightMode.Size = new System.Drawing.Size(111, 29);
            this.btnLightMode.TabIndex = 9;
            this.btnLightMode.Text = "Light mode";
            this.btnLightMode.UseVisualStyleBackColor = false;
            this.btnLightMode.Click += new System.EventHandler(this.btnLightMode_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(445, 405);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(46, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAndQuit
            // 
            this.btnSaveAndQuit.AutoSize = true;
            this.btnSaveAndQuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveAndQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAndQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAndQuit.Depth = 0;
            this.btnSaveAndQuit.Location = new System.Drawing.Point(526, 405);
            this.btnSaveAndQuit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveAndQuit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveAndQuit.Name = "btnSaveAndQuit";
            this.btnSaveAndQuit.Primary = true;
            this.btnSaveAndQuit.Size = new System.Drawing.Size(111, 36);
            this.btnSaveAndQuit.TabIndex = 11;
            this.btnSaveAndQuit.Text = "Save and quit";
            this.btnSaveAndQuit.UseVisualStyleBackColor = false;
            this.btnSaveAndQuit.Click += new System.EventHandler(this.btnSaveAndQuit_Click);
            // 
            // savedStatus
            // 
            this.savedStatus.BackColor = System.Drawing.Color.Transparent;
            this.savedStatus.Depth = 0;
            this.savedStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.savedStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.savedStatus.Location = new System.Drawing.Point(422, 380);
            this.savedStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.savedStatus.Name = "savedStatus";
            this.savedStatus.Size = new System.Drawing.Size(215, 19);
            this.savedStatus.TabIndex = 12;
            this.savedStatus.Text = "Not saved";
            this.savedStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoadTheme
            // 
            this.btnLoadTheme.AutoSize = true;
            this.btnLoadTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadTheme.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadTheme.Depth = 0;
            this.btnLoadTheme.Enabled = false;
            this.btnLoadTheme.Location = new System.Drawing.Point(422, 404);
            this.btnLoadTheme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadTheme.Name = "btnLoadTheme";
            this.btnLoadTheme.Primary = true;
            this.btnLoadTheme.Size = new System.Drawing.Size(96, 36);
            this.btnLoadTheme.TabIndex = 13;
            this.btnLoadTheme.Text = "Load theme";
            this.btnLoadTheme.UseVisualStyleBackColor = false;
            this.btnLoadTheme.Visible = false;
            this.btnLoadTheme.Click += new System.EventHandler(this.loadTheme_Click);
            // 
            // ThemeRGBTabs
            // 
            this.ThemeRGBTabs.Controls.Add(this.tabPage1);
            this.ThemeRGBTabs.Controls.Add(this.tabPage2);
            this.ThemeRGBTabs.Depth = 0;
            this.ThemeRGBTabs.Location = new System.Drawing.Point(10, 99);
            this.ThemeRGBTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeRGBTabs.Name = "ThemeRGBTabs";
            this.ThemeRGBTabs.SelectedIndex = 0;
            this.ThemeRGBTabs.Size = new System.Drawing.Size(390, 357);
            this.ThemeRGBTabs.TabIndex = 14;
            this.ThemeRGBTabs.SelectedIndexChanged += new System.EventHandler(this.ThemeRGBTabs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstP);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.lstPDark);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.lstPLight);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.lstA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Material Design Colors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.chkCustomBackgrounds);
            this.tabPage2.Controls.Add(this.panBackground);
            this.tabPage2.Controls.Add(this.panPrimaryAccent);
            this.tabPage2.Controls.Add(this.panPrimaryLight);
            this.tabPage2.Controls.Add(this.panPrimary);
            this.tabPage2.Controls.Add(this.panPrimaryDark);
            this.tabPage2.Controls.Add(this.materialDivider4);
            this.tabPage2.Controls.Add(this.materialDivider3);
            this.tabPage2.Controls.Add(this.materialDivider2);
            this.tabPage2.Controls.Add(this.materialDivider1);
            this.tabPage2.Controls.Add(this.materialLabel9);
            this.tabPage2.Controls.Add(this.materialLabel8);
            this.tabPage2.Controls.Add(this.lblBackgroundColor);
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custom RGB Colors";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.PrimaryCLAlpha);
            this.groupBox1.Controls.Add(this.BackgroundCAlpha);
            this.groupBox1.Controls.Add(this.PrimaryCDAlpha);
            this.groupBox1.Controls.Add(this.AccentCAlpha);
            this.groupBox1.Controls.Add(this.PrimaryCAlpha);
            this.groupBox1.Location = new System.Drawing.Point(6, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 44);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alpha Settings (Primary, PrimaryD, PrimaryL, Accent, Background)";
            // 
            // PrimaryCLAlpha
            // 
            this.PrimaryCLAlpha.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PrimaryCLAlpha.Location = new System.Drawing.Point(225, 16);
            this.PrimaryCLAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PrimaryCLAlpha.Name = "PrimaryCLAlpha";
            this.PrimaryCLAlpha.Size = new System.Drawing.Size(38, 22);
            this.PrimaryCLAlpha.TabIndex = 16;
            this.PrimaryCLAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PrimaryCLAlpha.ValueChanged += new System.EventHandler(this.PrimaryCLAlpha_ValueChanged);
            // 
            // BackgroundCAlpha
            // 
            this.BackgroundCAlpha.Enabled = false;
            this.BackgroundCAlpha.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BackgroundCAlpha.Location = new System.Drawing.Point(326, 16);
            this.BackgroundCAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BackgroundCAlpha.Name = "BackgroundCAlpha";
            this.BackgroundCAlpha.Size = new System.Drawing.Size(38, 22);
            this.BackgroundCAlpha.TabIndex = 18;
            this.BackgroundCAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BackgroundCAlpha.Visible = false;
            this.BackgroundCAlpha.ValueChanged += new System.EventHandler(this.BackgroundCAlpha_ValueChanged);
            // 
            // PrimaryCDAlpha
            // 
            this.PrimaryCDAlpha.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PrimaryCDAlpha.Location = new System.Drawing.Point(113, 16);
            this.PrimaryCDAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PrimaryCDAlpha.Name = "PrimaryCDAlpha";
            this.PrimaryCDAlpha.Size = new System.Drawing.Size(38, 22);
            this.PrimaryCDAlpha.TabIndex = 15;
            this.PrimaryCDAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PrimaryCDAlpha.ValueChanged += new System.EventHandler(this.PrimaryCDAlpha_ValueChanged);
            // 
            // AccentCAlpha
            // 
            this.AccentCAlpha.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AccentCAlpha.Location = new System.Drawing.Point(326, 16);
            this.AccentCAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AccentCAlpha.Name = "AccentCAlpha";
            this.AccentCAlpha.Size = new System.Drawing.Size(38, 22);
            this.AccentCAlpha.TabIndex = 17;
            this.AccentCAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AccentCAlpha.ValueChanged += new System.EventHandler(this.AccentCAlpha_ValueChanged);
            // 
            // PrimaryCAlpha
            // 
            this.PrimaryCAlpha.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PrimaryCAlpha.Location = new System.Drawing.Point(6, 16);
            this.PrimaryCAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PrimaryCAlpha.Name = "PrimaryCAlpha";
            this.PrimaryCAlpha.Size = new System.Drawing.Size(38, 22);
            this.PrimaryCAlpha.TabIndex = 14;
            this.PrimaryCAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PrimaryCAlpha.ValueChanged += new System.EventHandler(this.PrimaryCAlpha_ValueChanged);
            // 
            // chkCustomBackgrounds
            // 
            this.chkCustomBackgrounds.AutoSize = true;
            this.chkCustomBackgrounds.BackColor = System.Drawing.Color.Transparent;
            this.chkCustomBackgrounds.Depth = 0;
            this.chkCustomBackgrounds.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkCustomBackgrounds.Location = new System.Drawing.Point(174, 241);
            this.chkCustomBackgrounds.Margin = new System.Windows.Forms.Padding(0);
            this.chkCustomBackgrounds.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkCustomBackgrounds.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkCustomBackgrounds.Name = "chkCustomBackgrounds";
            this.chkCustomBackgrounds.Ripple = true;
            this.chkCustomBackgrounds.Size = new System.Drawing.Size(205, 30);
            this.chkCustomBackgrounds.TabIndex = 13;
            this.chkCustomBackgrounds.Text = "Enable custom backgrounds";
            this.chkCustomBackgrounds.UseVisualStyleBackColor = false;
            this.chkCustomBackgrounds.CheckedChanged += new System.EventHandler(this.chkCustomBackgrounds_CheckedChanged);
            // 
            // panBackground
            // 
            this.panBackground.BackColor = System.Drawing.Color.Transparent;
            this.panBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBackground.Location = new System.Drawing.Point(133, 235);
            this.panBackground.Name = "panBackground";
            this.panBackground.Size = new System.Drawing.Size(38, 40);
            this.panBackground.TabIndex = 12;
            this.panBackground.Click += new System.EventHandler(this.lblBackgroundColor_Click);
            // 
            // panPrimaryAccent
            // 
            this.panPrimaryAccent.BackColor = System.Drawing.Color.Transparent;
            this.panPrimaryAccent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPrimaryAccent.Location = new System.Drawing.Point(125, 173);
            this.panPrimaryAccent.Name = "panPrimaryAccent";
            this.panPrimaryAccent.Size = new System.Drawing.Size(251, 38);
            this.panPrimaryAccent.TabIndex = 11;
            this.panPrimaryAccent.Click += new System.EventHandler(this.panPrimaryAccent_Click);
            // 
            // panPrimaryLight
            // 
            this.panPrimaryLight.BackColor = System.Drawing.Color.Transparent;
            this.panPrimaryLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPrimaryLight.Location = new System.Drawing.Point(158, 113);
            this.panPrimaryLight.Name = "panPrimaryLight";
            this.panPrimaryLight.Size = new System.Drawing.Size(218, 38);
            this.panPrimaryLight.TabIndex = 10;
            this.panPrimaryLight.Click += new System.EventHandler(this.panPrimaryLight_Click);
            // 
            // panPrimary
            // 
            this.panPrimary.BackColor = System.Drawing.Color.Transparent;
            this.panPrimary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPrimary.Location = new System.Drawing.Point(125, 3);
            this.panPrimary.Name = "panPrimary";
            this.panPrimary.Size = new System.Drawing.Size(254, 38);
            this.panPrimary.TabIndex = 10;
            this.panPrimary.Click += new System.EventHandler(this.panPrimary_Click);
            // 
            // panPrimaryDark
            // 
            this.panPrimaryDark.BackColor = System.Drawing.Color.Transparent;
            this.panPrimaryDark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPrimaryDark.Location = new System.Drawing.Point(158, 56);
            this.panPrimaryDark.Name = "panPrimaryDark";
            this.panPrimaryDark.Size = new System.Drawing.Size(218, 38);
            this.panPrimaryDark.TabIndex = 9;
            this.panPrimaryDark.Click += new System.EventHandler(this.panPrimaryDark_Click);
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(6, 223);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(370, 3);
            this.materialDivider4.TabIndex = 8;
            this.materialDivider4.Text = "materialDivider4";
            this.materialDivider4.Visible = false;
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(6, 162);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(370, 3);
            this.materialDivider3.TabIndex = 7;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(6, 103);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(370, 3);
            this.materialDivider2.TabIndex = 6;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(6, 47);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(370, 3);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(6, 56);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(146, 38);
            this.materialLabel9.TabIndex = 4;
            this.materialLabel9.Text = "Primary color (dark):\r\nClick to change";
            this.materialLabel9.Click += new System.EventHandler(this.panPrimaryDark_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(6, 113);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(146, 38);
            this.materialLabel8.TabIndex = 3;
            this.materialLabel8.Text = "Primary color (light):\r\nClick to change";
            this.materialLabel8.Click += new System.EventHandler(this.panPrimaryLight_Click);
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Depth = 0;
            this.lblBackgroundColor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBackgroundColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBackgroundColor.Location = new System.Drawing.Point(6, 235);
            this.lblBackgroundColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(131, 38);
            this.lblBackgroundColor.TabIndex = 2;
            this.lblBackgroundColor.Text = "Background color:\r\nClick to change";
            this.lblBackgroundColor.Click += new System.EventHandler(this.lblBackgroundColor_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 173);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(113, 38);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "Accent color: \r\nClick to change";
            this.materialLabel6.Click += new System.EventHandler(this.panPrimaryAccent_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 3);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(113, 38);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Primary color:\r\nClick to change\r\n";
            this.materialLabel5.Click += new System.EventHandler(this.panPrimary_Click);
            // 
            // ThemeRGBTabsS
            // 
            this.ThemeRGBTabsS.BaseTabControl = this.ThemeRGBTabs;
            this.ThemeRGBTabsS.Depth = 0;
            this.ThemeRGBTabsS.Location = new System.Drawing.Point(0, 64);
            this.ThemeRGBTabsS.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeRGBTabsS.Name = "ThemeRGBTabsS";
            this.ThemeRGBTabsS.Size = new System.Drawing.Size(651, 29);
            this.ThemeRGBTabsS.TabIndex = 15;
            // 
            // PrimaryCD
            // 
            this.PrimaryCD.FullOpen = true;
            this.PrimaryCD.SolidColorOnly = true;
            // 
            // PrimaryDCD
            // 
            this.PrimaryDCD.FullOpen = true;
            this.PrimaryDCD.SolidColorOnly = true;
            // 
            // PrimaryLCD
            // 
            this.PrimaryLCD.FullOpen = true;
            this.PrimaryLCD.SolidColorOnly = true;
            // 
            // AccentCD
            // 
            this.AccentCD.FullOpen = true;
            this.AccentCD.SolidColorOnly = true;
            // 
            // BackgroundCD
            // 
            this.BackgroundCD.FullOpen = true;
            this.BackgroundCD.SolidColorOnly = true;
            // 
            // lblRGBMode
            // 
            this.lblRGBMode.BackColor = System.Drawing.Color.Transparent;
            this.lblRGBMode.Depth = 0;
            this.lblRGBMode.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGBMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRGBMode.Location = new System.Drawing.Point(402, 103);
            this.lblRGBMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRGBMode.Name = "lblRGBMode";
            this.lblRGBMode.Size = new System.Drawing.Size(243, 72);
            this.lblRGBMode.TabIndex = 16;
            this.lblRGBMode.Text = "RGB mode true - (Based on tab selection)\r\nDouble clicking \"Enabled custom backgro" +
    "unds\" will fix many theme problems";
            this.lblRGBMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpecial
            // 
            this.lblSpecial.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecial.Depth = 0;
            this.lblSpecial.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSpecial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSpecial.Location = new System.Drawing.Point(3, 5);
            this.lblSpecial.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(222, 22);
            this.lblSpecial.TabIndex = 17;
            this.lblSpecial.Text = "Special backgrounds";
            // 
            // chkDynamicOtherBackgrounds
            // 
            this.chkDynamicOtherBackgrounds.AutoSize = true;
            this.chkDynamicOtherBackgrounds.BackColor = System.Drawing.Color.Transparent;
            this.chkDynamicOtherBackgrounds.Depth = 0;
            this.chkDynamicOtherBackgrounds.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkDynamicOtherBackgrounds.Location = new System.Drawing.Point(7, 31);
            this.chkDynamicOtherBackgrounds.Margin = new System.Windows.Forms.Padding(0);
            this.chkDynamicOtherBackgrounds.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkDynamicOtherBackgrounds.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkDynamicOtherBackgrounds.Name = "chkDynamicOtherBackgrounds";
            this.chkDynamicOtherBackgrounds.Ripple = true;
            this.chkDynamicOtherBackgrounds.Size = new System.Drawing.Size(83, 30);
            this.chkDynamicOtherBackgrounds.TabIndex = 18;
            this.chkDynamicOtherBackgrounds.Text = "Dynamic";
            this.chkDynamicOtherBackgrounds.UseVisualStyleBackColor = false;
            this.chkDynamicOtherBackgrounds.CheckedChanged += new System.EventHandler(this.chkDynamicOtherBackgrounds_CheckChanged);
            // 
            // OtherBackgroundsCD
            // 
            this.OtherBackgroundsCD.AnyColor = true;
            this.OtherBackgroundsCD.Color = System.Drawing.SystemColors.ControlLight;
            this.OtherBackgroundsCD.FullOpen = true;
            this.OtherBackgroundsCD.SolidColorOnly = true;
            // 
            // btnChangeOtherBackground
            // 
            this.btnChangeOtherBackground.AutoSize = true;
            this.btnChangeOtherBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeOtherBackground.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeOtherBackground.Depth = 0;
            this.btnChangeOtherBackground.Location = new System.Drawing.Point(107, 30);
            this.btnChangeOtherBackground.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangeOtherBackground.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangeOtherBackground.Name = "btnChangeOtherBackground";
            this.btnChangeOtherBackground.Primary = true;
            this.btnChangeOtherBackground.Size = new System.Drawing.Size(114, 36);
            this.btnChangeOtherBackground.TabIndex = 19;
            this.btnChangeOtherBackground.Text = "Change color";
            this.btnChangeOtherBackground.UseVisualStyleBackColor = false;
            this.btnChangeOtherBackground.Click += new System.EventHandler(this.btnChangeOtherBackground_Click);
            // 
            // OtherBackgroundsExample
            // 
            this.OtherBackgroundsExample.Controls.Add(this.lblSpecial);
            this.OtherBackgroundsExample.Controls.Add(this.chkDynamicOtherBackgrounds);
            this.OtherBackgroundsExample.Controls.Add(this.btnChangeOtherBackground);
            this.OtherBackgroundsExample.Location = new System.Drawing.Point(412, 262);
            this.OtherBackgroundsExample.Name = "OtherBackgroundsExample";
            this.OtherBackgroundsExample.Size = new System.Drawing.Size(228, 69);
            this.OtherBackgroundsExample.TabIndex = 20;
            // 
            // ThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(650, 456);
            this.Controls.Add(this.lblRGBMode);
            this.Controls.Add(this.ThemeRGBTabsS);
            this.Controls.Add(this.savedStatus);
            this.Controls.Add(this.btnSaveAndQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLightMode);
            this.Controls.Add(this.btnDarkMode);
            this.Controls.Add(this.ThemeRGBTabs);
            this.Controls.Add(this.btnLoadTheme);
            this.Controls.Add(this.OtherBackgroundsExample);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Theme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemeForm_FormClosing);
            this.Load += new System.EventHandler(this.ThemeForm_Load);
            this.ThemeRGBTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryCLAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundCAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryCDAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccentCAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryCAlpha)).EndInit();
            this.OtherBackgroundsExample.ResumeLayout(false);
            this.OtherBackgroundsExample.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstP;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ListBox lstPDark;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ListBox lstPLight;
        private System.Windows.Forms.ListBox lstA;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton btnDarkMode;
        private MaterialSkin.Controls.MaterialRaisedButton btnLightMode;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private MaterialSkin.Controls.MaterialFlatButton btnSaveAndQuit;
        private MaterialSkin.Controls.MaterialLabel savedStatus;
        private MaterialSkin.Controls.MaterialFlatButton btnLoadTheme;
        private MaterialSkin.Controls.MaterialTabControl ThemeRGBTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector ThemeRGBTabsS;
        private System.Windows.Forms.ColorDialog PrimaryCD;
        private System.Windows.Forms.ColorDialog PrimaryDCD;
        private System.Windows.Forms.ColorDialog PrimaryLCD;
        private System.Windows.Forms.ColorDialog AccentCD;
        private System.Windows.Forms.ColorDialog BackgroundCD;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lblBackgroundColor;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Panel panPrimaryDark;
        private System.Windows.Forms.Panel panPrimary;
        private System.Windows.Forms.Panel panPrimaryLight;
        private System.Windows.Forms.Panel panPrimaryAccent;
        private MaterialSkin.Controls.MaterialLabel lblRGBMode;
        private System.Windows.Forms.Panel panBackground;
        private MaterialSkin.Controls.MaterialCheckBox chkCustomBackgrounds;
        private System.Windows.Forms.NumericUpDown PrimaryCAlpha;
        private System.Windows.Forms.NumericUpDown PrimaryCDAlpha;
        private System.Windows.Forms.NumericUpDown AccentCAlpha;
        private System.Windows.Forms.NumericUpDown PrimaryCLAlpha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown BackgroundCAlpha;
        private MaterialSkin.Controls.MaterialLabel lblSpecial;
        private MaterialSkin.Controls.MaterialCheckBox chkDynamicOtherBackgrounds;
        private System.Windows.Forms.ColorDialog OtherBackgroundsCD;
        private MaterialSkin.Controls.MaterialFlatButton btnChangeOtherBackground;
        private System.Windows.Forms.Panel OtherBackgroundsExample;
    }
}