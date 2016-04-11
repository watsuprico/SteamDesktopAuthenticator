using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Configuration;

namespace Steam_Desktop_Authenticator
{
    public partial class SetTheme : Form
    {

        Manifest manifest;
        private readonly MaterialSkinManager materialSkinManager;

        public SetTheme()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
        }

        private void SetTheme_Load(object sender, EventArgs e)
        {
            setThemeTime.Interval = 500;
            setThemeTime.Start();
        }

        private void btnNoTheme_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["noTheme"] = "true";
            Close();
        }

        private void setThemeTime_Tick(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["noTheme"] != "true")
            {
                // Get latest manifest
                manifest = Manifest.GetManifest(true);
                try {
                    if (manifest.ThemeDark) materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                    else materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    if (manifest.ThemeRGB)
                    {
                        materialSkinManager.bgColorEnabled = manifest.ThemeBackground_Enabled;
                        materialSkinManager.bgColor = manifest.ThemeBackground_RGB;
                        materialSkinManager.ColorScheme = new ColorScheme(manifest.ThemePrimary_RGB, manifest.ThemePrimaryD_RGB, manifest.ThemePrimaryL_RGB, manifest.ThemeAccent_RGB, TextShade.WHITE);
                    }
                    else { materialSkinManager.bgColorEnabled = false; materialSkinManager.ColorScheme = new ColorScheme((object)manifest.ThemePrimary, (object)manifest.ThemePrimaryD, (object)manifest.ThemePrimaryL, (object)manifest.ThemeAccent, TextShade.WHITE); }
                }
                catch (Exception ee)
                { MessageBox.Show($"Error while applying theme: {ee.ToString()}", "Error applying theme.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            manifest.FirstRun = true;
            manifest.Save();
            Application.Restart();
        }
    }
}
