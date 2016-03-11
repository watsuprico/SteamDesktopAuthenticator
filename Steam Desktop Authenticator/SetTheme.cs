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

namespace Steam_Desktop_Authenticator
{
    public partial class SetTheme : Form
    {

        bool noTheme = false;
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
            noTheme = true;
            Close();
        }

        private void setThemeTime_Tick(object sender, EventArgs e)
        {
            if (noTheme != true)
            {
                // Get latest manifest
                manifest = Manifest.GetManifest(true);

                if (manifest.ThemeDark)
                    materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                else
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(manifest.ThemePrimary, manifest.ThemePrimaryD, manifest.ThemePrimaryL, manifest.ThemeAccent, TextShade.WHITE);
            }
            Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KeyPressed(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift && Control.ModifierKeys == Keys.F10)
            {
                //Reset
                manifest.FirstRun = true;
                manifest.Save();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            manifest.FirstRun = true;
            manifest.Save();
            Close();
        }
    }
}
