using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace Steam_Desktop_Authenticator
{
    static class Program
    {
        public static Process PriorProcess()
        // Returns a System.Diagnostics.Process pointing to
        // a pre-existing process with the same name as the
        // current one, if any; or null if the current process
        // is unique.
        {
            try
            {
                Process curr = Process.GetCurrentProcess();
                Process[] procs = Process.GetProcessesByName(curr.ProcessName);
                foreach (Process p in procs)
                {
                    if ((p.Id != curr.Id) &&
                        (p.MainModule.FileName == curr.MainModule.FileName))
                        return p;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // run the program only once
            if (PriorProcess() != null)
            {
                MessageBox.Show("Another instance of SDA is already running.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool close = false;
            bool selfcrypt = false;

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            if (config.AppSettings.Settings["EncryptManifest"] != null && config.AppSettings.Settings["ManifestEncrypted"] != null && config.AppSettings.Settings["EncryptionKey"] != null && config.AppSettings.Settings["EncryptionSALT"] != null && config.AppSettings.Settings["EncryptionIV"] != null)
            {
                if (config.AppSettings.Settings["ManifestEncrypted"].Value == "true" && config.AppSettings.Settings["EncryptManifest"].Value == "true")
                {
                    // Decrypt by ourselfs?
                    if (config.AppSettings.Settings["EncryptionDeStart"] != null && config.AppSettings.Settings["EncryptionSTARTUP"] != null)
                    {
                        if (config.AppSettings.Settings["EncryptionDeStart"].Value == "true" && config.AppSettings.Settings["EncryptionSTARTUP"].Value != "")
                            selfcrypt = true;
                        else
                            selfcrypt = false;
                    }
                    else
                        selfcrypt = false;

                    string curPassKey = "";

                    if (selfcrypt)
                        curPassKey = FileEncryptor.DecryptData(config.AppSettings.Settings["EncryptionSALT"].Value, config.AppSettings.Settings["EncryptionSALT"].Value, config.AppSettings.Settings["EncryptionIV"].Value, config.AppSettings.Settings["EncryptionSTARTUP"].Value);
                    else
                    {
                        // Get the code
                        InputForm currentPassKeyForm = new InputForm("Enter current passkey", true);
                        currentPassKeyForm.StartPosition = FormStartPosition.CenterScreen; currentPassKeyForm.txtBox.UseSystemPasswordChar = true;
                        currentPassKeyForm.ShowDialog();
                        currentPassKeyForm.StartPosition = FormStartPosition.CenterParent;
                        if (currentPassKeyForm.Canceled) { currentPassKeyForm.txtBox.UseSystemPasswordChar = false; return; }
                        curPassKey = currentPassKeyForm.txtBox.Text; currentPassKeyForm.txtBox.UseSystemPasswordChar = false;
                        currentPassKeyForm.txtBox.Text = "";
                    }

                    if (config.AppSettings.Settings["EncryptionKey"].Value == FileEncryptor.EncryptData(curPassKey, config.AppSettings.Settings["EncryptionSALT"].Value, config.AppSettings.Settings["EncryptionIV"].Value, curPassKey))
                        try
                        {
                            System.IO.File.WriteAllText(Manifest.GetExecutableDir() + "\\maFiles\\manifest.json", FileEncryptor.DecryptData(curPassKey, config.AppSettings.Settings["EncryptionSALT"].Value, config.AppSettings.Settings["EncryptionIV"].Value, System.IO.File.ReadAllText(Manifest.GetExecutableDir() + "\\maFiles\\manifest.json")));
                            config.AppSettings.Settings["ManifestEncrypted"].Value = "false";
                            config.AppSettings.Settings["EncryptionKey"].Value = FileEncryptor.EncryptData(curPassKey, config.AppSettings.Settings["EncryptionSALT"].Value, config.AppSettings.Settings["EncryptionIV"].Value, curPassKey);
                            ConfigurationManager.AppSettings["EncrpytKey"] = curPassKey;
                            config.Save(ConfigurationSaveMode.Minimal);
                        }
                        catch (Exception a)
                        { MessageBox.Show("Uh oh! Failed to decrypt manifest." + Environment.NewLine + a.ToString()); }
                    else
                    { MessageBox.Show("Incorrect passkey )^:" + Environment.NewLine + "If you enabled auto decrypt, you're pretty much screwed..", "Incorrect passkey", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit(); close = true; }
                }
            }

            if (!close)
            {
                Application.Run(new SetTheme());

                Manifest man = Manifest.GetManifest();
                if (man.FirstRun)
                {
                    // Install VC++ Redist and wait
                    new InstallRedistribForm().ShowDialog();

                    if (man.Entries.Count > 0)
                    {
                        // Already has accounts, just run
                        Application.Run(new MainForm());
                    }
                    else
                    {
                        // No accounts, run welcome form
                        Application.Run(new WelcomeForm());
                    }
                }
                else
                {
                    Application.Run(new MainForm());
                }
            }
        }
    }
}
