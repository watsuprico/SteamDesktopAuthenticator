using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.Diagnostics;

namespace Steam_Desktop_Authenticator
{
    public partial class DownloadUpdate : MaterialForm
    {
        Stopwatch sw = new Stopwatch();

        private readonly MaterialSkinManager materialSkinManager;
        public DownloadUpdate(string url)
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            Directory.CreateDirectory("update\\");
            string path = Manifest.GetExecutableDir() + "\\update\\update.zip";

            WebClient client = new WebClient();
            sw.Start();
            client.DownloadFileAsync(new Uri(url), path);
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
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
    }
}
