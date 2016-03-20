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
            this.lstP.Location = new System.Drawing.Point(12, 97);
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
            this.materialLabel1.Location = new System.Drawing.Point(59, 75);
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
            this.materialLabel2.Location = new System.Drawing.Point(241, 75);
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
            this.lstPDark.Location = new System.Drawing.Point(211, 97);
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
            this.materialLabel3.Location = new System.Drawing.Point(44, 223);
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
            this.lstPLight.Location = new System.Drawing.Point(12, 245);
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
            this.lstA.Location = new System.Drawing.Point(211, 245);
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
            this.materialLabel4.Location = new System.Drawing.Point(258, 223);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(56, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Accent";
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarkMode.Depth = 0;
            this.btnDarkMode.Location = new System.Drawing.Point(380, 118);
            this.btnDarkMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Primary = true;
            this.btnDarkMode.Size = new System.Drawing.Size(111, 29);
            this.btnDarkMode.TabIndex = 8;
            this.btnDarkMode.Text = "Dark mode";
            this.btnDarkMode.UseVisualStyleBackColor = true;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // btnLightMode
            // 
            this.btnLightMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightMode.Depth = 0;
            this.btnLightMode.Location = new System.Drawing.Point(380, 153);
            this.btnLightMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLightMode.Name = "btnLightMode";
            this.btnLightMode.Primary = true;
            this.btnLightMode.Size = new System.Drawing.Size(111, 29);
            this.btnLightMode.TabIndex = 9;
            this.btnLightMode.Text = "Light mode";
            this.btnLightMode.UseVisualStyleBackColor = true;
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
            this.btnSave.Location = new System.Drawing.Point(414, 256);
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
            this.btnSaveAndQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAndQuit.Depth = 0;
            this.btnSaveAndQuit.Location = new System.Drawing.Point(380, 303);
            this.btnSaveAndQuit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveAndQuit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveAndQuit.Name = "btnSaveAndQuit";
            this.btnSaveAndQuit.Primary = true;
            this.btnSaveAndQuit.Size = new System.Drawing.Size(111, 36);
            this.btnSaveAndQuit.TabIndex = 11;
            this.btnSaveAndQuit.Text = "Save and quit";
            this.btnSaveAndQuit.UseVisualStyleBackColor = true;
            this.btnSaveAndQuit.Click += new System.EventHandler(this.btnSaveAndQuit_Click);
            // 
            // savedStatus
            // 
            this.savedStatus.Depth = 0;
            this.savedStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.savedStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.savedStatus.Location = new System.Drawing.Point(380, 223);
            this.savedStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.savedStatus.Name = "savedStatus";
            this.savedStatus.Size = new System.Drawing.Size(111, 19);
            this.savedStatus.TabIndex = 12;
            this.savedStatus.Text = "Not saved";
            this.savedStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoadTheme
            // 
            this.btnLoadTheme.AutoSize = true;
            this.btnLoadTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadTheme.Depth = 0;
            this.btnLoadTheme.Enabled = false;
            this.btnLoadTheme.Location = new System.Drawing.Point(388, 256);
            this.btnLoadTheme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadTheme.Name = "btnLoadTheme";
            this.btnLoadTheme.Primary = true;
            this.btnLoadTheme.Size = new System.Drawing.Size(96, 36);
            this.btnLoadTheme.TabIndex = 13;
            this.btnLoadTheme.Text = "Load theme";
            this.btnLoadTheme.UseVisualStyleBackColor = true;
            this.btnLoadTheme.Visible = false;
            this.btnLoadTheme.Click += new System.EventHandler(this.loadTheme_Click);
            // 
            // ThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 365);
            this.Controls.Add(this.btnLoadTheme);
            this.Controls.Add(this.savedStatus);
            this.Controls.Add(this.btnSaveAndQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLightMode);
            this.Controls.Add(this.btnDarkMode);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lstA);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lstPLight);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lstPDark);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lstP);
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
    }
}