﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Steam_Desktop_Authenticator
{
    public partial class InstallRedistribForm : MaterialForm
    {
        private bool inlineInstall = false;
        Stopwatch sw = new Stopwatch();

        private readonly MaterialSkinManager materialSkinManager;

        public InstallRedistribForm(bool inlineInstall = false)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            progressBar1.Minimum = 0;

            string path = Manifest.GetExecutableDir() + "/vcredist_x86.exe";

            WebClient client = new WebClient();
            sw.Start();
            client.DownloadFileAsync(new Uri("https://download.microsoft.com/download/2/E/6/2E61CFA4-993B-4DD4-91DA-3737CD5CD6E3/vcredist_x86.exe"), path);
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Manifest.GetExecutableDir() + "/vcredist_x86.exe";
                startInfo.Verb = "runas";
                startInfo.Arguments = "/q";
                startInfo.WindowStyle = ProcessWindowStyle.Normal;

                Process installProcess = new Process();
                installProcess.StartInfo = startInfo;
                installProcess.EnableRaisingEvents = true;
                installProcess.Exited += InstallProcess_Exited;
                installProcess.Start();
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        private void InstallProcess_Exited(object sender, EventArgs e)
        {
            if (inlineInstall)
            {
                MessageBox.Show("Install complete! You may need to restart Steam Desktop Authenticator to view trade confirmations.", "Visual C++ Redistributable 2013", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            });
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadStatus.Text = "Downloading Visual C++ Redistributable 2013" + Environment.NewLine + "Downloaded " + (e.BytesReceived / 1048576) + "MB(s) of " + (e.TotalBytesToReceive / 1048576) + "MBs." + Environment.NewLine + e.ProgressPercentage + "% downloaded" + Environment.NewLine + (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00") + " kb/s";
            progressBar1.Maximum = (int)e.TotalBytesToReceive;
            progressBar1.Value = (int)e.BytesReceived;
        }
    }
}
