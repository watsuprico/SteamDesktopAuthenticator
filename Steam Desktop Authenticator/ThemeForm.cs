﻿using System;
using System.Drawing;
using System.Configuration;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Steam_Desktop_Authenticator
{
    public partial class ThemeForm : MaterialForm
    {

        Manifest manifest;
        #region Vars
        private readonly MaterialSkinManager materialSkinManager;
        private Primary primaryColor;
        private Primary primaryColorLight;
        private Primary primaryColorDark;
        private Accent accentColor;

        private Color primaryColorRGB;
        private Color primaryColorLightRGB;
        private Color primaryColorDarkRGB;
        private Color accentColorRGB;
        private Color BackgroundColorRGB;

        private string accentColor1;
        private string primaryColor1;
        private string primaryColorLight1;
        private string primaryColorDark1;

        private Primary p;
        private Accent a;
        private bool darkTheme;

        public bool noTheme;

        private bool notSaved = false;
        private bool rgbMode;
        private bool CustomBackgrounds;
        private Color OtherBackgrounds_Color;
        private bool starting;
        #endregion

        #region Loading and closing methods
        public ThemeForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            manifest = Manifest.GetManifest(true);
            if (ConfigurationManager.AppSettings["noTheme"] != "true")
                noTheme = false;
            else
                noTheme = true;
        }

        private void ThemeForm_Load(object sender, EventArgs e)
        {
            manifest = Manifest.GetManifest();
            starting = true;

            lblRGBMode.Font = new Font("Roboto", 10);

            if (manifest.ThemeRGB) { rgbMode = true; ThemeRGBTabs.SelectedIndex = 1; } // RGB enabled, show RGB tab
            else { rgbMode = false; ThemeRGBTabs.SelectedIndex = 0; } // RGB disabled, show non-RGB tab

            primaryColor = manifest.ThemePrimary;
            primaryColorDark = manifest.ThemePrimaryD;
            primaryColorLight = manifest.ThemePrimaryL;
            accentColor = manifest.ThemeAccent;

            primaryColorRGB = manifest.ThemePrimary_RGB;
            primaryColorDarkRGB = manifest.ThemePrimaryD_RGB;
            primaryColorLightRGB = manifest.ThemePrimaryL_RGB;
            accentColorRGB = manifest.ThemeAccent_RGB;

            CustomBackgrounds = manifest.ThemeBackground_Enabled;
            chkCustomBackgrounds.Checked = manifest.ThemeBackground_Enabled;
            BackgroundColorRGB = manifest.ThemeBackground_RGB;

            if (manifest.ThemeOtherBackgrounds_Dynamic)
                { if (manifest.ThemeDark) OtherBackgroundsExample.BackColor = OtherBackgrounds_Color = SystemColors.ControlLight; else OtherBackgrounds_Color = OtherBackgroundsExample.BackColor = SystemColors.ControlDark; }
            else OtherBackgrounds_Color = manifest.ThemeOtherBackgrounds_Color;

            chkDynamicOtherBackgrounds.Checked = manifest.ThemeOtherBackgrounds_Dynamic;
            btnChangeOtherBackground.Enabled = btnChangeOtherBackground.Primary = !manifest.ThemeOtherBackgrounds_Dynamic;

            setSelectors();

            darkTheme = manifest.ThemeDark;
            if (noTheme)
            {
                savedStatus.Text = "Themes disabled!";
                btnLoadTheme.Enabled = btnLoadTheme.Visible = true;
                groupBox1.Enabled = chkCustomBackgrounds.Enabled = ThemeRGBTabsS.Enabled = btnSave.Enabled = btnSave.Visible = btnSaveAndQuit.Enabled = lstA.Enabled = lstP.Enabled = lstPDark.Enabled = lstPLight.Enabled = panPrimary.Enabled = panPrimaryDark.Enabled = panPrimaryLight.Enabled = panPrimaryAccent.Enabled = false;
            }
            else
            {
                setSelectors();
                Save();
            }
            reTheme(true);
            starting = false;
        }

        private void ThemeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!noTheme)
            {
                if (notSaved)
                {
                    var result = MessageBox.Show("Warning: you've not saved your theme changes. Are you sure you would like to discard these theme changes?", "Warning!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                        e.Cancel = true;
                    else
                        reTheme(true);
                }
                else
                    reTheme(true);
            }
        }
        #endregion

        #region Methods (functions)
        // Sets the theme
        private void reTheme(bool b)
        {
            try
            {
                if (!noTheme)
                {
                    setSelectors();
                    if (b) // If true set the theme as defined in the manifest (only when closing)
                    {
                        manifest = Manifest.GetManifest(true);
                        if (manifest.ThemeDark) materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                        else materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                        if (manifest.ThemeRGB) { materialSkinManager.bgColorEnabled = manifest.ThemeBackground_Enabled; materialSkinManager.bgColor = manifest.ThemeBackground_RGB; materialSkinManager.ColorScheme = new ColorScheme(manifest.ThemePrimary_RGB, manifest.ThemePrimaryD_RGB, manifest.ThemePrimaryL_RGB, manifest.ThemeAccent_RGB, TextShade.WHITE); }
                        else { materialSkinManager.bgColorEnabled = false; materialSkinManager.ColorScheme = new ColorScheme((object)manifest.ThemePrimary, (object)manifest.ThemePrimaryD, (object)manifest.ThemePrimaryL, (object)manifest.ThemeAccent, TextShade.WHITE); }
                    }
                    else // Other wise, set it based on our vars
                    {
                        if (darkTheme) materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                        else materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                        if (rgbMode) { materialSkinManager.bgColor = BackgroundColorRGB; materialSkinManager.bgColorEnabled = CustomBackgrounds; materialSkinManager.ColorScheme = new ColorScheme(primaryColorRGB, primaryColorDarkRGB, primaryColorLightRGB, accentColorRGB, TextShade.WHITE); }
                        else { materialSkinManager.bgColorEnabled = false; materialSkinManager.ColorScheme = new ColorScheme((object)primaryColor, (object)primaryColorDark, (object)primaryColorLight, (object)accentColor, TextShade.WHITE); }
                        if (rgbMode && CustomBackgrounds && BackgroundColorRGB != null)
                            BackColor = BackgroundColorRGB;
                    }
                }
            }
            catch (Exception e)
            { MessageBox.Show($"Error while applying theme: {e.ToString()}", "Error applying theme.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Setup the selectors
        private void setSelectors()
        {
            try
            {
                lstP.SelectedIndex = lstP.FindStringExact(primaryColor.ToString());
                lstPDark.SelectedIndex = lstPDark.FindStringExact(primaryColorDark.ToString());
                lstPLight.SelectedIndex = lstPLight.FindStringExact(primaryColorLight.ToString());
                lstA.SelectedIndex = lstA.FindStringExact(accentColor.ToString());

                panPrimary.BackColor = primaryColorRGB;
                panPrimaryDark.BackColor = primaryColorDarkRGB;
                panPrimaryLight.BackColor = primaryColorLightRGB;
                panPrimaryAccent.BackColor = accentColorRGB;
                panBackground.BackColor = BackgroundColorRGB;

                PrimaryCAlpha.Value = primaryColorRGB.A;
                PrimaryCDAlpha.Value = primaryColorDarkRGB.A;
                PrimaryCLAlpha.Value = primaryColorLightRGB.A;
                AccentCAlpha.Value = accentColorRGB.A;

                groupBox1.BackColor = OtherBackgroundsExample.BackColor;
                OtherBackgroundsExample.BackColor = OtherBackgrounds_Color;
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error while setting up the selectors!" + Environment.NewLine + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Something was changed!

        private void updateTheme()
        {
            if (!noTheme)
            {
                savedStatus.Text = "Not saved";
                notSaved = btnSave.Enabled = btnSaveAndQuit.Enabled = true;
                if (!rgbMode)
                {
                    try { primaryColor1 = (string)lstP.Items[lstP.SelectedIndex]; } catch { primaryColor1 = primaryColor.ToString(); }
                    try { primaryColorDark1 = (string)lstPDark.Items[lstPDark.SelectedIndex]; } catch { primaryColorDark1 = primaryColorDark.ToString(); }
                    try { primaryColorLight1 = (string)lstPLight.Items[lstPLight.SelectedIndex]; } catch { primaryColorLight1 = primaryColorLight.ToString(); }
                    try { accentColor1 = (string)lstA.Items[lstA.SelectedIndex]; } catch { accentColor1 = accentColor.ToString(); }
                    translateString();
                }

                #region Check if anything was *actually* changed
                if (chkDynamicOtherBackgrounds.Checked == manifest.ThemeOtherBackgrounds_Dynamic && OtherBackgrounds_Color == manifest.ThemeOtherBackgrounds_Color && primaryColor == manifest.ThemePrimary && primaryColorDark == manifest.ThemePrimaryD && primaryColorLight == manifest.ThemePrimaryL && primaryColorRGB == manifest.ThemePrimary_RGB && primaryColorDarkRGB == manifest.ThemePrimaryD_RGB && primaryColorLightRGB == manifest.ThemePrimaryL_RGB && accentColor == manifest.ThemeAccent && accentColorRGB == manifest.ThemeAccent_RGB && rgbMode == manifest.ThemeRGB && CustomBackgrounds == manifest.ThemeBackground_Enabled && BackgroundColorRGB == manifest.ThemeBackground_RGB && darkTheme == manifest.ThemeDark)
                { savedStatus.Text = "Already saved"; notSaved = btnSave.Enabled = btnSaveAndQuit.Enabled = false; } // Nothing actually changed )^:
                #endregion
                
                reTheme(false);
            }
        }

        // Save the settings

        private void Save()
        {
            if (!noTheme)
            {
                savedStatus.Text = "Saving";
                manifest.ThemePrimary = primaryColor;
                manifest.ThemePrimaryD = primaryColorDark;
                manifest.ThemePrimaryL = primaryColorLight;
                manifest.ThemeAccent = accentColor;
                manifest.ThemeDark = darkTheme;

                manifest.ThemePrimary_RGB = primaryColorRGB;
                manifest.ThemePrimaryD_RGB = primaryColorDarkRGB;
                manifest.ThemePrimaryL_RGB = primaryColorLightRGB;
                manifest.ThemeAccent_RGB = accentColorRGB;

                if (rgbMode)
                    manifest.ThemeRGB = true;
                else
                    manifest.ThemeRGB = false;

                manifest.ThemeBackground_Enabled = chkCustomBackgrounds.Checked;
                manifest.ThemeBackground_RGB = BackgroundColorRGB;

                manifest.ThemeOtherBackgrounds_Color = OtherBackgrounds_Color;
                manifest.ThemeOtherBackgrounds_Dynamic = chkDynamicOtherBackgrounds.Checked;

                manifest.Save();
                savedStatus.Text = "Saved";
                notSaved = btnSave.Enabled = btnSaveAndQuit.Enabled = false;
            }
        }
        #endregion

        #region Buttons
        private void btnLightMode_Click(object sender, EventArgs e)
        {
            darkTheme = false;
            updateTheme();
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            darkTheme = true;
            updateTheme();
        }

        private void btnSaveAndQuit_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void loadTheme_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["noTheme"] == "true")
            {
                noTheme = false;
                ConfigurationManager.AppSettings["noTheme"] = "false";

                reTheme(true);

                savedStatus.Text = "Theme loaded";
                groupBox1.Enabled = chkCustomBackgrounds.Enabled = ThemeRGBTabsS.Enabled = btnSave.Enabled = btnSave.Visible = btnSaveAndQuit.Enabled = lstA.Enabled = lstP.Enabled = lstPDark.Enabled = lstPLight.Enabled = panPrimary.Enabled = panPrimaryDark.Enabled = panPrimaryLight.Enabled = panPrimaryAccent.Enabled = true;
                btnLoadTheme.Enabled = btnLoadTheme.Visible = false;
                setSelectors();
                Save();
            }
        }
        #endregion

        #region NonRGB selectors
        // nonRGB setting changed

        private void lstP_SelectedValueChanged(object sender, EventArgs e) { updateTheme(); }

        // Change that string to a Primary or an Accent type

        private void translateString()
        {
            stringToPrimary(primaryColor1);
            primaryColor = p;
            stringToPrimary(primaryColorDark1);
            primaryColorDark = p;
            stringToPrimary(primaryColorLight1);
            primaryColorLight = p;
            stringToAccent(accentColor1);
            accentColor = a;
        }

        private void stringToPrimary(string s)
        {
            try
            {
                if (s == "Red50") { p = Primary.Red50; }
                else if (s == "Red100") { p = Primary.Red100; }
                else if (s == "Red200") { p = Primary.Red200; }
                else if (s == "Red300") { p = Primary.Red300; }
                else if (s == "Red400") { p = Primary.Red400; }
                else if (s == "Red500") { p = Primary.Red500; }
                else if (s == "Red600") { p = Primary.Red600; }
                else if (s == "Red700") { p = Primary.Red700; }
                else if (s == "Red800") { p = Primary.Red800; }
                else if (s == "Red900") { p = Primary.Red900; }
                else if (s == "Pink50") { p = Primary.Pink50; }
                else if (s == "Pink100") { p = Primary.Pink100; }
                else if (s == "Pink200") { p = Primary.Pink200; }
                else if (s == "Pink300") { p = Primary.Pink300; }
                else if (s == "Pink400") { p = Primary.Pink400; }
                else if (s == "Pink500") { p = Primary.Pink500; }
                else if (s == "Pink600") { p = Primary.Pink600; }
                else if (s == "Pink700") { p = Primary.Pink700; }
                else if (s == "Pink800") { p = Primary.Pink800; }
                else if (s == "Pink900") { p = Primary.Pink900; }
                else if (s == "Purple50") { p = Primary.Purple50; }
                else if (s == "Purple100") { p = Primary.Purple100; }
                else if (s == "Purple200") { p = Primary.Purple200; }
                else if (s == "Purple300") { p = Primary.Purple300; }
                else if (s == "Purple400") { p = Primary.Purple400; }
                else if (s == "Purple500") { p = Primary.Purple500; }
                else if (s == "Purple600") { p = Primary.Purple600; }
                else if (s == "Purple700") { p = Primary.Purple700; }
                else if (s == "Purple800") { p = Primary.Purple800; }
                else if (s == "Purple900") { p = Primary.Purple900; }
                else if (s == "DeepPurple50") { p = Primary.DeepPurple50; }
                else if (s == "DeepPurple100") { p = Primary.DeepPurple100; }
                else if (s == "DeepPurple200") { p = Primary.DeepPurple200; }
                else if (s == "DeepPurple300") { p = Primary.DeepPurple300; }
                else if (s == "DeepPurple400") { p = Primary.DeepPurple400; }
                else if (s == "DeepPurple500") { p = Primary.DeepPurple500; }
                else if (s == "DeepPurple600") { p = Primary.DeepPurple600; }
                else if (s == "DeepPurple700") { p = Primary.DeepPurple700; }
                else if (s == "DeepPurple800") { p = Primary.DeepPurple800; }
                else if (s == "DeepPurple900") { p = Primary.DeepPurple900; }
                else if (s == "Indigo50") { p = Primary.Indigo50; }
                else if (s == "Indigo100") { p = Primary.Indigo100; }
                else if (s == "Indigo200") { p = Primary.Indigo200; }
                else if (s == "Indigo300") { p = Primary.Indigo300; }
                else if (s == "Indigo400") { p = Primary.Indigo400; }
                else if (s == "Indigo500") { p = Primary.Indigo500; }
                else if (s == "Indigo600") { p = Primary.Indigo600; }
                else if (s == "Indigo700") { p = Primary.Indigo700; }
                else if (s == "Indigo800") { p = Primary.Indigo800; }
                else if (s == "Indigo900") { p = Primary.Indigo900; }
                else if (s == "Blue50") { p = Primary.Blue50; }
                else if (s == "Blue100") { p = Primary.Blue100; }
                else if (s == "Blue200") { p = Primary.Blue200; }
                else if (s == "Blue300") { p = Primary.Blue300; }
                else if (s == "Blue400") { p = Primary.Blue400; }
                else if (s == "Blue500") { p = Primary.Blue500; }
                else if (s == "Blue600") { p = Primary.Blue600; }
                else if (s == "Blue700") { p = Primary.Blue700; }
                else if (s == "Blue800") { p = Primary.Blue800; }
                else if (s == "Blue900") { p = Primary.Blue900; }
                else if (s == "LightBlue50") { p = Primary.LightBlue50; }
                else if (s == "LightBlue100") { p = Primary.LightBlue100; }
                else if (s == "LightBlue200") { p = Primary.LightBlue200; }
                else if (s == "LightBlue300") { p = Primary.LightBlue300; }
                else if (s == "LightBlue400") { p = Primary.LightBlue400; }
                else if (s == "LightBlue500") { p = Primary.LightBlue500; }
                else if (s == "LightBlue600") { p = Primary.LightBlue600; }
                else if (s == "LightBlue700") { p = Primary.LightBlue700; }
                else if (s == "LightBlue800") { p = Primary.LightBlue800; }
                else if (s == "LightBlue900") { p = Primary.LightBlue900; }
                else if (s == "Cyan50") { p = Primary.Cyan50; }
                else if (s == "Cyan100") { p = Primary.Cyan100; }
                else if (s == "Cyan200") { p = Primary.Cyan200; }
                else if (s == "Cyan300") { p = Primary.Cyan300; }
                else if (s == "Cyan400") { p = Primary.Cyan400; }
                else if (s == "Cyan500") { p = Primary.Cyan500; }
                else if (s == "Cyan600") { p = Primary.Cyan600; }
                else if (s == "Cyan700") { p = Primary.Cyan700; }
                else if (s == "Cyan800") { p = Primary.Cyan800; }
                else if (s == "Cyan900") { p = Primary.Cyan900; }
                else if (s == "Teal50") { p = Primary.Teal50; }
                else if (s == "Teal100") { p = Primary.Teal100; }
                else if (s == "Teal200") { p = Primary.Teal200; }
                else if (s == "Teal300") { p = Primary.Teal300; }
                else if (s == "Teal400") { p = Primary.Teal400; }
                else if (s == "Teal500") { p = Primary.Teal500; }
                else if (s == "Teal600") { p = Primary.Teal600; }
                else if (s == "Teal700") { p = Primary.Teal700; }
                else if (s == "Teal800") { p = Primary.Teal800; }
                else if (s == "Teal900") { p = Primary.Teal900; }
                else if (s == "Green50") { p = Primary.Green50; }
                else if (s == "Green100") { p = Primary.Green100; }
                else if (s == "Green200") { p = Primary.Green200; }
                else if (s == "Green300") { p = Primary.Green300; }
                else if (s == "Green400") { p = Primary.Green400; }
                else if (s == "Green500") { p = Primary.Green500; }
                else if (s == "Green600") { p = Primary.Green600; }
                else if (s == "Green700") { p = Primary.Green700; }
                else if (s == "Green800") { p = Primary.Green800; }
                else if (s == "Green900") { p = Primary.Green900; }
                else if (s == "LightGreen50") { p = Primary.LightGreen50; }
                else if (s == "LightGreen100") { p = Primary.LightGreen100; }
                else if (s == "LightGreen200") { p = Primary.LightGreen200; }
                else if (s == "LightGreen300") { p = Primary.LightGreen300; }
                else if (s == "LightGreen400") { p = Primary.LightGreen400; }
                else if (s == "LightGreen500") { p = Primary.LightGreen500; }
                else if (s == "LightGreen600") { p = Primary.LightGreen600; }
                else if (s == "LightGreen700") { p = Primary.LightGreen700; }
                else if (s == "LightGreen800") { p = Primary.LightGreen800; }
                else if (s == "LightGreen900") { p = Primary.LightGreen900; }
                else if (s == "Lime50") { p = Primary.Lime50; }
                else if (s == "Lime100") { p = Primary.Lime100; }
                else if (s == "Lime200") { p = Primary.Lime200; }
                else if (s == "Lime300") { p = Primary.Lime300; }
                else if (s == "Lime400") { p = Primary.Lime400; }
                else if (s == "Lime500") { p = Primary.Lime500; }
                else if (s == "Lime600") { p = Primary.Lime600; }
                else if (s == "Lime700") { p = Primary.Lime700; }
                else if (s == "Lime800") { p = Primary.Lime800; }
                else if (s == "Lime900") { p = Primary.Lime900; }
                else if (s == "Yellow50") { p = Primary.Yellow50; }
                else if (s == "Yellow100") { p = Primary.Yellow100; }
                else if (s == "Yellow200") { p = Primary.Yellow200; }
                else if (s == "Yellow300") { p = Primary.Yellow300; }
                else if (s == "Yellow400") { p = Primary.Yellow400; }
                else if (s == "Yellow500") { p = Primary.Yellow500; }
                else if (s == "Yellow600") { p = Primary.Yellow600; }
                else if (s == "Yellow700") { p = Primary.Yellow700; }
                else if (s == "Yellow800") { p = Primary.Yellow800; }
                else if (s == "Yellow900") { p = Primary.Yellow900; }
                else if (s == "Amber50") { p = Primary.Amber50; }
                else if (s == "Amber100") { p = Primary.Amber100; }
                else if (s == "Amber200") { p = Primary.Amber200; }
                else if (s == "Amber300") { p = Primary.Amber300; }
                else if (s == "Amber400") { p = Primary.Amber400; }
                else if (s == "Amber500") { p = Primary.Amber500; }
                else if (s == "Amber600") { p = Primary.Amber600; }
                else if (s == "Amber700") { p = Primary.Amber700; }
                else if (s == "Amber800") { p = Primary.Amber800; }
                else if (s == "Amber900") { p = Primary.Amber900; }
                else if (s == "Orange50") { p = Primary.Orange50; }
                else if (s == "Orange100") { p = Primary.Orange100; }
                else if (s == "Orange200") { p = Primary.Orange200; }
                else if (s == "Orange300") { p = Primary.Orange300; }
                else if (s == "Orange400") { p = Primary.Orange400; }
                else if (s == "Orange500") { p = Primary.Orange500; }
                else if (s == "Orange600") { p = Primary.Orange600; }
                else if (s == "Orange700") { p = Primary.Orange700; }
                else if (s == "Orange800") { p = Primary.Orange800; }
                else if (s == "Orange900") { p = Primary.Orange900; }
                else if (s == "DeepOrange50") { p = Primary.DeepOrange50; }
                else if (s == "DeepOrange100") { p = Primary.DeepOrange100; }
                else if (s == "DeepOrange200") { p = Primary.DeepOrange200; }
                else if (s == "DeepOrange300") { p = Primary.DeepOrange300; }
                else if (s == "DeepOrange400") { p = Primary.DeepOrange400; }
                else if (s == "DeepOrange500") { p = Primary.DeepOrange500; }
                else if (s == "DeepOrange600") { p = Primary.DeepOrange600; }
                else if (s == "DeepOrange700") { p = Primary.DeepOrange700; }
                else if (s == "DeepOrange800") { p = Primary.DeepOrange800; }
                else if (s == "DeepOrange900") { p = Primary.DeepOrange900; }
                else if (s == "Brown50") { p = Primary.Brown50; }
                else if (s == "Brown100") { p = Primary.Brown100; }
                else if (s == "Brown200") { p = Primary.Brown200; }
                else if (s == "Brown300") { p = Primary.Brown300; }
                else if (s == "Brown400") { p = Primary.Brown400; }
                else if (s == "Brown500") { p = Primary.Brown500; }
                else if (s == "Brown600") { p = Primary.Brown600; }
                else if (s == "Brown700") { p = Primary.Brown700; }
                else if (s == "Brown800") { p = Primary.Brown800; }
                else if (s == "Brown900") { p = Primary.Brown900; }
                else if (s == "Grey50") { p = Primary.Grey50; }
                else if (s == "Grey100") { p = Primary.Grey100; }
                else if (s == "Grey200") { p = Primary.Grey200; }
                else if (s == "Grey300") { p = Primary.Grey300; }
                else if (s == "Grey400") { p = Primary.Grey400; }
                else if (s == "Grey500") { p = Primary.Grey500; }
                else if (s == "Grey600") { p = Primary.Grey600; }
                else if (s == "Grey700") { p = Primary.Grey700; }
                else if (s == "Grey800") { p = Primary.Grey800; }
                else if (s == "Grey900") { p = Primary.Grey900; }
                else if (s == "BlueGrey50") { p = Primary.BlueGrey50; }
                else if (s == "BlueGrey100") { p = Primary.BlueGrey100; }
                else if (s == "BlueGrey200") { p = Primary.BlueGrey200; }
                else if (s == "BlueGrey300") { p = Primary.BlueGrey300; }
                else if (s == "BlueGrey400") { p = Primary.BlueGrey400; }
                else if (s == "BlueGrey500") { p = Primary.BlueGrey500; }
                else if (s == "BlueGrey600") { p = Primary.BlueGrey600; }
                else if (s == "BlueGrey700") { p = Primary.BlueGrey700; }
                else if (s == "BlueGrey800") { p = Primary.BlueGrey800; }
                else if (s == "BlueGrey900") { p = Primary.BlueGrey900; }
            }
            catch
            {
                p = Primary.Cyan800;
                MessageBox.Show("There was an error translating the string.");
            }
        }

        private void stringToAccent(string s)
        {
            try
            {
                if (s == "Red100") { a = Accent.Red100; }
                if (s == "Red200") { a = Accent.Red200; }
                if (s == "Red400") { a = Accent.Red400; }
                if (s == "Red700") { a = Accent.Red700; }
                if (s == "Pink100") { a = Accent.Pink100; }
                if (s == "Pink200") { a = Accent.Pink200; }
                if (s == "Pink400") { a = Accent.Pink400; }
                if (s == "Pink700") { a = Accent.Pink700; }
                if (s == "Purple100") { a = Accent.Purple100; }
                if (s == "Purple200") { a = Accent.Purple200; }
                if (s == "Purple400") { a = Accent.Purple400; }
                if (s == "Purple700") { a = Accent.Purple700; }
                if (s == "DeepPurple100") { a = Accent.DeepPurple100; }
                if (s == "DeepPurple200") { a = Accent.DeepPurple200; }
                if (s == "DeepPurple400") { a = Accent.DeepPurple400; }
                if (s == "DeepPurple700") { a = Accent.DeepPurple700; }
                if (s == "Indigo100") { a = Accent.Indigo100; }
                if (s == "Indigo200") { a = Accent.Indigo200; }
                if (s == "Indigo400") { a = Accent.Indigo400; }
                if (s == "Indigo700") { a = Accent.Indigo700; }
                if (s == "Blue100") { a = Accent.Blue100; }
                if (s == "Blue200") { a = Accent.Blue200; }
                if (s == "Blue400") { a = Accent.Blue400; }
                if (s == "Blue700") { a = Accent.Blue700; }
                if (s == "LightBlue100") { a = Accent.LightBlue100; }
                if (s == "LightBlue200") { a = Accent.LightBlue200; }
                if (s == "LightBlue400") { a = Accent.LightBlue400; }
                if (s == "LightBlue700") { a = Accent.LightBlue700; }
                if (s == "Cyan100") { a = Accent.Cyan100; }
                if (s == "Cyan200") { a = Accent.Cyan200; }
                if (s == "Cyan400") { a = Accent.Cyan400; }
                if (s == "Cyan700") { a = Accent.Cyan700; }
                if (s == "Teal100") { a = Accent.Teal100; }
                if (s == "Teal200") { a = Accent.Teal200; }
                if (s == "Teal400") { a = Accent.Teal400; }
                if (s == "Teal700") { a = Accent.Teal700; }
                if (s == "Green100") { a = Accent.Green100; }
                if (s == "Green200") { a = Accent.Green200; }
                if (s == "Green400") { a = Accent.Green400; }
                if (s == "Green700") { a = Accent.Green700; }
                if (s == "LightGreen100") { a = Accent.LightGreen100; }
                if (s == "LightGreen200") { a = Accent.LightGreen200; }
                if (s == "LightGreen400") { a = Accent.LightGreen400; }
                if (s == "LightGreen700") { a = Accent.LightGreen700; }
                if (s == "Lime100") { a = Accent.Lime100; }
                if (s == "Lime200") { a = Accent.Lime200; }
                if (s == "Lime400") { a = Accent.Lime400; }
                if (s == "Lime700") { a = Accent.Lime700; }
                if (s == "Yellow100") { a = Accent.Yellow100; }
                if (s == "Yellow200") { a = Accent.Yellow200; }
                if (s == "Yellow400") { a = Accent.Yellow400; }
                if (s == "Yellow700") { a = Accent.Yellow700; }
                if (s == "Amber100") { a = Accent.Amber100; }
                if (s == "Amber200") { a = Accent.Amber200; }
                if (s == "Amber400") { a = Accent.Amber400; }
                if (s == "Amber700") { a = Accent.Amber700; }
                if (s == "Orange100") { a = Accent.Orange100; }
                if (s == "Orange200") { a = Accent.Orange200; }
                if (s == "Orange400") { a = Accent.Orange400; }
                if (s == "Orange700") { a = Accent.Orange700; }
                if (s == "DeepOrange100") { a = Accent.DeepOrange100; }
                if (s == "DeepOrange200") { a = Accent.DeepOrange200; }
                if (s == "DeepOrange400") { a = Accent.DeepOrange400; }
                if (s == "DeepOrange700") { a = Accent.DeepOrange700; }
                if (s == "Grey50") { a = Accent.Grey50; }
                if (s == "Grey100") { a = Accent.Grey100; }
                if (s == "Grey200") { a = Accent.Grey200; }
                if (s == "Grey300") { a = Accent.Grey300; }
                if (s == "Grey400") { a = Accent.Grey400; }
                if (s == "Grey500") { a = Accent.Grey500; }
                if (s == "Grey600") { a = Accent.Grey600; }
                if (s == "Grey700") { a = Accent.Grey700; }
                if (s == "Grey800") { a = Accent.Grey800; }
                if (s == "Grey900") { a = Accent.Grey900; }
            }
            catch
            {
                a = Accent.Amber400;
                MessageBox.Show("There was an error translating the string.");
            }
        }
        #endregion

        #region RGB selector's value(s) changed
        private void panPrimary_Click(object sender, EventArgs e)
        {
            if (!noTheme)
            {
                PrimaryCD.Color = primaryColorRGB;
                if (PrimaryCD.ShowDialog() == DialogResult.OK)
                {
                    primaryColorRGB = PrimaryCD.Color;
                    updateTheme();
                }
            }
        }

        private void panPrimaryDark_Click(object sender, EventArgs e)
        {
            if (!noTheme)
            {
                PrimaryDCD.Color = primaryColorDarkRGB;
                if (PrimaryDCD.ShowDialog() == DialogResult.OK)
                {
                    primaryColorDarkRGB = PrimaryDCD.Color;
                    updateTheme();
                }
            }
        }

        private void panPrimaryLight_Click(object sender, EventArgs e)
        {
            if (!noTheme)
            {
                PrimaryLCD.Color = primaryColorDarkRGB;
                if (PrimaryLCD.ShowDialog() == DialogResult.OK)
                {
                    primaryColorLightRGB = PrimaryLCD.Color;
                    updateTheme();
                }
            }
        }

        private void panPrimaryAccent_Click(object sender, EventArgs e)
        {
            if (!noTheme)
            {
                AccentCD.Color = accentColorRGB;
                if (AccentCD.ShowDialog() == DialogResult.OK)
                {
                    accentColorRGB = AccentCD.Color;
                    updateTheme();
                }
            }
        }
        private void lblBackgroundColor_Click(object sender, EventArgs e)
        {
            if (!noTheme)
            {
                BackgroundCD.Color = BackgroundColorRGB;
                if (BackgroundCD.ShowDialog() == DialogResult.OK)
                {
                    BackgroundColorRGB = BackgroundCD.Color;
                    System.Threading.Thread.Sleep(100);
                    updateTheme();
                }
            }
        }
        private void chkCustomBackgrounds_CheckedChanged(object sender, EventArgs e)
        {
            if (!noTheme)
            {
                CustomBackgrounds = chkCustomBackgrounds.Checked;
                updateTheme();
            }
        }
        #endregion

        #region Alpha selector's value(s) changed
        private void PrimaryCAlpha_ValueChanged(object sender, EventArgs e)
        { primaryColorRGB = Color.FromArgb((int)PrimaryCAlpha.Value, primaryColorRGB.R, primaryColorRGB.G, primaryColorRGB.B); updateTheme(); }

        private void PrimaryCDAlpha_ValueChanged(object sender, EventArgs e)
        { primaryColorDarkRGB = Color.FromArgb((int)PrimaryCDAlpha.Value, primaryColorDarkRGB.R, primaryColorDarkRGB.G, primaryColorDarkRGB.B); updateTheme(); }

        private void PrimaryCLAlpha_ValueChanged(object sender, EventArgs e)
        { primaryColorLightRGB = Color.FromArgb((int)PrimaryCLAlpha.Value, primaryColorLightRGB.R, primaryColorLightRGB.G, primaryColorLightRGB.B); updateTheme(); }

        private void AccentCAlpha_ValueChanged(object sender, EventArgs e)
        { accentColorRGB = Color.FromArgb((int)AccentCAlpha.Value, accentColorRGB.R, accentColorRGB.G, accentColorRGB.B); updateTheme(); }
        #endregion

        // The tab changed (changing RGB mode with it)
        private void ThemeRGBTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ThemeRGBTabs.SelectedIndex == 0) // On the non-RGB selectors
                rgbMode = false;
            else // On the RGB selectors
                rgbMode = true;
            lblRGBMode.Text = $"RGB Mode {rgbMode}!" + Environment.NewLine + "(Based on tag selection)" + Environment.NewLine + "Double clicking \"Enable custom backgrounds\" will fix many theme problems.";
            updateTheme();
        }

        private void BackgroundCAlpha_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (int)BackgroundCAlpha.Value;
        }


        #region Other background settings
        private void chkDynamicOtherBackgrounds_CheckChanged(object sender, EventArgs e)
        {
            if (!starting)
            {
                btnChangeOtherBackground.Enabled = btnChangeOtherBackground.Primary = !chkDynamicOtherBackgrounds.Checked;
                if (chkDynamicOtherBackgrounds.Checked)
                {
                    if (darkTheme) OtherBackgroundsExample.BackColor = OtherBackgrounds_Color = SystemColors.ControlLight;
                    else OtherBackgroundsExample.BackColor = OtherBackgrounds_Color = SystemColors.ControlDark;
                }
                else OtherBackgroundsExample.BackColor = OtherBackgrounds_Color = manifest.ThemeOtherBackgrounds_Color;
                updateTheme();
            }
        }

        private void btnChangeOtherBackground_Click(object sender, EventArgs e)
        {
            if (!chkDynamicOtherBackgrounds.Checked)
            {
                OtherBackgroundsCD.Color = OtherBackgrounds_Color;
                if (OtherBackgroundsCD.ShowDialog() == DialogResult.OK)
                {
                    OtherBackgrounds_Color = OtherBackgroundsCD.Color;
                    OtherBackgroundsExample.BackColor = OtherBackgroundsCD.Color;
                    updateTheme();
                }
            }
        }
        #endregion
    }
}
