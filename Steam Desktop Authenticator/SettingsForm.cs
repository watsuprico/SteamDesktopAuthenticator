using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Configuration;

namespace Steam_Desktop_Authenticator
{
    public partial class SettingsForm : MaterialForm
    {
        Manifest manifest;
        bool fullyLoaded = false;
        bool cancel = false;

        private readonly MaterialSkinManager materialSkinManager;
        public SettingsForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Get latest manifest
            manifest = Manifest.GetManifest(true);

            chkPeriodicChecking.Checked = manifest.PeriodicChecking;
            numPeriodicInterval.Value = manifest.PeriodicCheckingInterval;
            chkCheckAll.Checked = manifest.CheckAllAccounts;
            chkConfirmMarket.Checked = manifest.AutoConfirmMarketTransactions;
            chkConfirmTrades.Checked = manifest.AutoConfirmTrades;
            chkUpdates.Checked = manifest.CheckForUpdates;
            SetControlsEnabledState(chkPeriodicChecking.Checked);

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            if (config.AppSettings.Settings["EncryptManifest"] != null)
            {
                if (config.AppSettings.Settings["EncryptManifest"].Value == "true")
                {
                    chkEncryptManifest.Checked = true; txtManifestPasskey.Text = ConfigurationManager.AppSettings["EncrpytKey"];

                    if (config.AppSettings.Settings["EncryptionNewSALT"] != null)
                    {
                        if (config.AppSettings.Settings["EncryptionNewSALT"].Value == "true")
                            chkNewSalt.Checked = true;
                        else
                            chkNewSalt.Checked = false;
                    }

                    if (config.AppSettings.Settings["EncryptionDeStart"] != null)
                    {
                        if (config.AppSettings.Settings["EncryptionDeStart"].Value == "true")
                            chkDecryptOnStart.Checked = true;
                        else
                            chkDecryptOnStart.Checked = false;
                    }

                }
                else
                    chkEncryptManifest.Checked = chkDecryptOnStart.Checked = chkNewSalt.Checked = false;
            }
            txtManifestPasskey.Enabled = chkNewSalt.Enabled = chkDecryptOnStart.Enabled = chkEncryptManifest.Checked; // Fallback
            fullyLoaded = true;
        }

        private void SetControlsEnabledState(bool enabled)
        {
            numPeriodicInterval.Enabled = chkCheckAll.Enabled = chkConfirmMarket.Enabled = chkConfirmTrades.Enabled = enabled;
        }

        private void ShowWarning(CheckBox affectedBox)
        {
            if (!fullyLoaded) return;

            var result = MessageBox.Show("Warning: enabling this will severely reduce the security of your items! Use of this option is at your own risk. Would you like to continue?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                affectedBox.Checked = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cancel = false;
            manifest.PeriodicChecking = chkPeriodicChecking.Checked;
            manifest.PeriodicCheckingInterval = (int)numPeriodicInterval.Value;
            manifest.CheckAllAccounts = chkCheckAll.Checked;
            manifest.AutoConfirmMarketTransactions = chkConfirmMarket.Checked;
            manifest.AutoConfirmTrades = chkConfirmTrades.Checked;
            manifest.CheckForUpdates = chkUpdates.Checked;
            manifest.Save();

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                if (chkEncryptManifest.Checked || txtManifestPasskey.Enabled)
                {
                    if (txtManifestPasskey.Text != null && txtManifestPasskey.Text != "" && config.AppSettings.Settings["EncryptionSALT"] != null && config.AppSettings.Settings["EncryptionIV"].Value != null)
                    {
                        ConfigurationManager.AppSettings["EncrpytKey"] = txtManifestPasskey.Text;
                        config.AppSettings.Settings["EncryptionKey"].Value = FileEncryptor.EncryptData(ConfigurationManager.AppSettings["EncrpytKey"], config.AppSettings.Settings["EncryptionSALT"].Value, config.AppSettings.Settings["EncryptionIV"].Value, ConfigurationManager.AppSettings["EncrpytKey"]);
                        if (chkEncryptManifest.Checked)
                            config.AppSettings.Settings["EncryptManifest"].Value = "true";
                        else
                            config.AppSettings.Settings["EncryptManifest"].Value = "false";

                        if (chkNewSalt.Checked)
                            config.AppSettings.Settings["EncryptionNewSALT"].Value = "true";
                        else
                            config.AppSettings.Settings["EncryptionNewSALT"].Value = "false";
                        if (chkDecryptOnStart.Checked)
                        { config.AppSettings.Settings["EncryptionDeStart"].Value = "true"; config.AppSettings.Settings["EncryptionSTARTUP"].Value = FileEncryptor.EncryptData(config.AppSettings.Settings["EncryptionSALT"].Value, config.AppSettings.Settings["EncryptionSALT"].Value, config.AppSettings.Settings["EncryptionIV"].Value, txtManifestPasskey.Text); }
                        else
                        { config.AppSettings.Settings["EncryptionDeStart"].Value = "false"; config.AppSettings.Settings["EncryptionSTARTUP"].Value = ""; }
                    }
                    else
                    {
                        MessageBox.Show("You have to set a encryption passkey to encrypt the manifest.", "No encryption passkey!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cancel = true;
                    }
                }
                else
                    config.AppSettings.Settings["EncryptManifest"].Value = "false";
                config.Save(ConfigurationSaveMode.Minimal);
            }
            catch (Exception eee)
            { MessageBox.Show("Error saving manifest encryption settings: " + Environment.NewLine + eee.ToString()); }

            if (!cancel)
                this.Close();
        }

        private void chkPeriodicChecking_CheckedChanged(object sender, EventArgs e)
        {
            SetControlsEnabledState(chkPeriodicChecking.Checked);
        }

        private void chkConfirmMarket_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfirmMarket.Checked)
                ShowWarning(chkConfirmMarket);
        }

        private void chkConfirmTrades_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfirmTrades.Checked)
                ShowWarning(chkConfirmTrades);
        }
        private void chkPeriodicChecking_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkPeriodicChecking.Checked)
                chkCheckAll.Enabled = chkConfirmMarket.Enabled = chkConfirmTrades.Enabled = true;
            else
                chkCheckAll.Enabled = chkConfirmMarket.Enabled = chkConfirmTrades.Enabled = false;
        }

        private void chkEncryptManifest_CheckedChanged(object sender, EventArgs e)
        {
            txtManifestPasskey.Enabled = chkNewSalt.Enabled = chkDecryptOnStart.Enabled = chkEncryptManifest.Checked;
            if (fullyLoaded)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                if (chkEncryptManifest.Checked)
                {
                    DialogResult updateDialog = MessageBox.Show("THIS IS STILL IN BETA! I TAKE NO RESPONSIBILITY FOR ANY DAMAGE CAUSED BY THIS." + Environment.NewLine + "THIS STORES THE KEY IN PLAIN TEXT IN THE APP SETTINGS FILE! IT CAN ALSO DELETE YOU MANIFEST FILE, (WHICH DELETES ALL ACCOUNTS LINKED TO THIS PROGRAM). THIS MEAN YOU WILL LOSE YOUR ACCOUNTS IF SOMETHING BAD HAPPENS." + Environment.NewLine + "THIS ALSO DOES NOT ENCRYPT THE STEAM ACCOUNT FILES, SO SOMEONE COULD STILL TAKE THEM AND LINK THEM TO THEIR SDA INSTALL." + Environment.NewLine + "Encrypt manifest?", "WARNING: THIS COULD DELETE ALL ACCOUNTS FROM SDA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (updateDialog == DialogResult.Yes)
                    {
                        if (config.AppSettings.Settings["EncryptionKey"] != null)
                            txtManifestPasskey.Text = ConfigurationManager.AppSettings["EncrpytKey"];
                    }
                    else
                        chkEncryptManifest.Checked = false;

                }

                if (chkEncryptManifest.Checked)
                {
                    if (config.AppSettings.Settings["ManifestEncrypted"] == null)
                        config.AppSettings.Settings.Add("ManifestEncrypted", "false");

                    if (config.AppSettings.Settings["EncryptionIV"] == null)
                        config.AppSettings.Settings.Add("EncryptionIV", FileEncryptor.GetInitializationVector());

                    if (config.AppSettings.Settings["EncryptionSALT"] == null)
                        config.AppSettings.Settings.Add("EncryptionSALT", FileEncryptor.GetRandomSalt());

                    if (config.AppSettings.Settings["EncryptionKey"] == null)
                        config.AppSettings.Settings.Add("EncryptionKey", "");

                    if (config.AppSettings.Settings["EncryptionNewSALT"] == null)
                    {
                        config.AppSettings.Settings.Add("EncryptionNewSALT", "false");
                        chkNewSalt.Checked = false;
                    }
                    else if (config.AppSettings.Settings["EncryptionNewSALT"].Value == "true")
                        chkNewSalt.Checked = true;
                    else
                        chkNewSalt.Checked = false;

                    if (config.AppSettings.Settings["EncryptionDeStart"] == null)
                    {
                        config.AppSettings.Settings.Add("EncryptionDeStart", "false");
                        chkDecryptOnStart.Checked = false;
                    }
                    else if (config.AppSettings.Settings["EncryptionDeStart"].Value == "true")
                        chkDecryptOnStart.Checked = true;
                    else
                        chkDecryptOnStart.Checked = false;

                    if (config.AppSettings.Settings["EncryptionSTARTUP"] == null)
                        config.AppSettings.Settings.Add("EncryptionSTARTUP", "");

                    if (config.AppSettings.Settings["EncryptManifest"] == null)
                        config.AppSettings.Settings.Add("EncryptManifest", "true");
                    else
                        config.AppSettings.Settings["EncryptManifest"].Value = "true";
                }
                config.Save(ConfigurationSaveMode.Minimal);
            }
        }

        private void chkDecryptOnStart_CheckedChanged(object sender, EventArgs e)
        {
            if (fullyLoaded)
            {
                if (chkDecryptOnStart.Checked)
                {
                    DialogResult updateDialog = MessageBox.Show("Are you sure you would like SDA to decrypt the manifest on its own? This will weaken the security a bit." + Environment.NewLine + "This would allow anyone who has accesses to the SDA install and a background on how manifest get encrypted to easily decrypt the passkey and unlock your manifest.", "Weaken manifest encryption security for ease of use ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (updateDialog != DialogResult.Yes)
                        chkDecryptOnStart.Checked = false;
                    else
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                        if (txtManifestPasskey.Text != null && txtManifestPasskey.Text != "" && config.AppSettings.Settings["EncryptionSALT"].Value != null && config.AppSettings.Settings["EncryptionIV"].Value != null)
                            config.AppSettings.Settings["EncryptionSTARTUP"].Value = FileEncryptor.EncryptData(config.AppSettings.Settings["EncryptionSALT"].Value, config.AppSettings.Settings["EncryptionSALT"].Value, config.AppSettings.Settings["EncryptionIV"].Value, txtManifestPasskey.Text);
                        config.Save(ConfigurationSaveMode.Minimal);
                    }

                }
                else
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                    config.AppSettings.Settings["EncryptionSTARTUP"].Value = "";
                    config.Save(ConfigurationSaveMode.Minimal);
                }
            }
        }
    }
}
