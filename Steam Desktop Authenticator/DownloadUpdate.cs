using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Steam_Desktop_Authenticator
{
    public partial class DownloadUpdate : MaterialForm
    {
        private Manifest manifest;

        Stopwatch sw = new Stopwatch();
        WebClient client = new WebClient();

        // Logic for whats new checking
        private WebClient updateClient = null;

        private readonly MaterialSkinManager materialSkinManager;
        public DownloadUpdate(string url)
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            try
            {
                if (manifest.ThemeOtherBackgrounds_Dynamic)
                {
                    if (manifest.ThemeDark) AboutUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
                    else AboutUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
                }
                else AboutUpdate.BackColor = manifest.ThemeOtherBackgrounds_Color;
            }
            catch { }

            this.MinimumSize = new System.Drawing.Size(285, 210);
            this.MaximumSize = new System.Drawing.Size(570, 420);

            Directory.CreateDirectory("update\\");
            string path = Manifest.GetExecutableDir() + "\\update\\update.zip";

            updateClient = new WebClient();
            updateClient.DownloadStringCompleted += UpdateClient_DownloadStringCompleted;
            updateClient.Headers.Add("Content-Type", "application/json");
            updateClient.Headers.Add("User-Agent", "Steam Desktop Authenticator");
            updateClient.DownloadStringAsync(new Uri("https://api.github.com/repos/watsuprico/SteamDesktopAuthenticator/releases/latest"));

            sw.Start();
            client.DownloadFileAsync(new Uri(url), path);
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.Close(); // Method that disposes the client and unhooks events
                return;
            }
            try
            {
                sw.Reset();
                var archive = ZipFile.OpenRead(Directory.GetCurrentDirectory() + "\\update\\update.zip");
                this.Text = "Extracting file(s)";
                statusBar.Maximum = archive.Entries.Count - 1;
                for (int i = 0; i < archive.Entries.Count - 1; i++)
                {
                    try
                    {
                        ZipArchiveEntry entry = archive.Entries[i];
                        if (entry.FullName == "Extract Update.exe") { File.Delete(Directory.GetCurrentDirectory() + "\\update\\" + entry.FullName); entry.ExtractToFile(Directory.GetCurrentDirectory() + "\\update\\" + entry.FullName); }
                        statusBar.Value = i;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error while extracting \"Extract Update.exe\"!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                DialogResult res = MessageBox.Show("Update and restart SDA?", "Update using Extract Update.exe?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Manifest.GetExecutableDir() + "\\update\\Extract Update.exe");
                    Application.Exit();
                }
                else
                    MessageBox.Show("You have yet to update SDA. Either run \"" + Manifest.GetExecutableDir() + "\\update\\Extract Update.exe\" to extract and update automaticaly, or extract \"" + Manifest.GetExecutableDir() + "\\update\\update.zip\", (up a directory), to update SDA.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadStatus.Text = "Downloaded " + (e.BytesReceived / 1048576) + "MB(s) of " + (e.TotalBytesToReceive / 1048576) + "MBs." + Environment.NewLine + e.ProgressPercentage + "% downloaded" + Environment.NewLine + (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00") + " kb/s";
            statusBar.Maximum = (int)e.TotalBytesToReceive;
            statusBar.Value = (int)e.BytesReceived;
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
            client.Dispose();
        }

        private void UpdateClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                dynamic resultObject = JsonConvert.DeserializeObject(e.Result);
                AboutUpdate.Text = $"Updating from {new Version(Application.ProductVersion)} to {new Version(resultObject.tag_name.Value)}" + Environment.NewLine + "What's new:" + Environment.NewLine + resultObject.body.Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to check for updates.");
            }
        }
    }
}
