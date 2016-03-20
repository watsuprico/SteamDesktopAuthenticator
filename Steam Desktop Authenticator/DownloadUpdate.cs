using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Steam_Desktop_Authenticator
{
    public partial class DownloadUpdate : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;
        public DownloadUpdate(string url)
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            string path = Manifest.GetExecutableDir() + "\\update.zip";

            WebClient client = new WebClient();
            client.DownloadFileAsync(new Uri(url), path);
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Update and restart SDA?", "Update using Extract Update.exe?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Manifest.GetExecutableDir() + "\\Extract Update.exe");
                    Application.Exit();
                }
                else
                    MessageBox.Show("The update has not been extracted, however, running \"" + Manifest.GetExecutableDir() + "\\Extract Update.exe\" or extracting \"" + Manifest.GetExecutableDir() + "\\update.zip\" will extract and update SDA.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while extracting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            statusBar.Maximum = (int)e.TotalBytesToReceive;
            statusBar.Value = (int)e.BytesReceived;
        }
    }
}
