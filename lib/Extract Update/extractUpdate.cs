using System;
using System.Linq;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace Extract_Update
{
    public partial class extractUpdate : Form
    {
        public extractUpdate()
        {
            InitializeComponent();
        }

        private void extractUpdate_Load(object sender, EventArgs e)
        {
            extractTime.Enabled = true;
        }

        private void extractTime_Tick(object sender, EventArgs e)
        {
            extractTime.Enabled = false;
            try
            {
                var archive = ZipFile.OpenRead(Directory.GetCurrentDirectory() + "\\update.zip");
                statusBar.Maximum = archive.Entries.Count - 1;
                statusBar.Minimum = 0;

                for (int i = 0; i < archive.Entries.Count - 1; i++)
                {
                    try
                    {
                        ZipArchiveEntry entry = archive.Entries[i];
                        fileNames.Text = fileNames.Text + Environment.NewLine + "Extracting: " + entry.FullName;
                        fileNames.SelectionStart = fileNames.Text.Length;
                        fileNames.ScrollToCaret();
                        System.IO.File.Delete(Directory.GetCurrentDirectory() + "\\" + entry.FullName);
                        entry.ExtractToFile(Directory.GetCurrentDirectory() + "\\" + entry.FullName);
                        statusBar.Value = i;
                    }
                    catch (Exception ex)
                    {
                       MessageBox.Show(ex.Message, "Error while extracting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message, "Error while extracting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                    Application.Exit();
            }

            DialogResult ress = MessageBox.Show("Extraction complete!", "Extraction complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (ress == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\Steam Desktop Authenticator.exe");
                Application.Exit();
            }
        }
    }
}
