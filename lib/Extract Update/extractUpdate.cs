using System;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace Extract_Update
{
    public partial class extractUpdate : Form
    {
        private string extractTo;

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
            extract();
        }

        private void fileNames_TextChanged(object sender, EventArgs e)
        {
            fileNames.SelectionStart = fileNames.Text.Length;
            fileNames.ScrollToCaret();
        }


        private void extract()
        {
            try
            {
                if (Directory.GetCurrentDirectory().EndsWith(@"\update")) //IF we are IN the update folder
                {
                    if (File.Exists(Directory.GetCurrentDirectory() + @"\update.zip"))
                    {
                        var archive = ZipFile.OpenRead(Directory.GetCurrentDirectory() + @"\update.zip");
                        statusBar.Maximum = archive.Entries.Count - 1;
                        statusBar.Minimum = 0;
                        for (int i = 0; i < archive.Entries.Count - 1; i++)
                        {
                            try
                            {
                                ZipArchiveEntry entry = archive.Entries[i];
                                if (entry.FullName == System.AppDomain.CurrentDomain.FriendlyName || entry.FullName.EndsWith("/") || entry.FullName.EndsWith("\\"))
                                    fileNames.Text = fileNames.Text + Environment.NewLine + "Can't extract: " + entry.FullName;
                                else
                                {
                                    fileNames.Text = fileNames.Text + Environment.NewLine + "Extracting: " + entry.FullName;
                                    if (File.Exists(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\")) + entry.FullName))
                                        System.IO.File.Delete(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\")) + entry.FullName);
                                    entry.ExtractToFile(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\")) + entry.FullName);
                                }
                                statusBar.Value = i;
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while extracting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                    }
                    else
                    {
                        // Allow the user to find the update file
                        DialogResult resss = MessageBox.Show("The update file was not found. Would you like to find it?", "Error while extracting", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (resss == DialogResult.Yes)
                            FindUpdate();
                        else
                            Application.Exit();
                    }
                }
                else
                {
                    if (File.Exists(Directory.GetCurrentDirectory() + @"\update.zip"))
                    {
                        var archive = ZipFile.OpenRead(Directory.GetCurrentDirectory() + @"\update.zip");
                        statusBar.Maximum = archive.Entries.Count - 1;
                        statusBar.Minimum = 0;
                        for (int i = 0; i < archive.Entries.Count - 1; i++)
                        {
                            try
                            {
                                ZipArchiveEntry entry = archive.Entries[i];
                                if (entry.FullName == System.AppDomain.CurrentDomain.FriendlyName || entry.FullName.EndsWith("/") || entry.FullName.EndsWith("\\"))
                                    fileNames.Text = fileNames.Text + Environment.NewLine + "Can't extract: " + entry.FullName;
                                else
                                {
                                    fileNames.Text = fileNames.Text + Environment.NewLine + "Extracting: " + entry.FullName;
                                    if (File.Exists(Directory.GetCurrentDirectory() + entry.FullName))
                                        System.IO.File.Delete(Directory.GetCurrentDirectory() + entry.FullName);
                                    entry.ExtractToFile(Directory.GetCurrentDirectory() + entry.FullName);
                                }
                                statusBar.Value = i;
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message, "Error while extracting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                    }
                    else
                    {
                        // Allow the user to find the update file
                        DialogResult resss = MessageBox.Show("The update file was not found. Would you like to find it?", "Error while extracting", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (resss == DialogResult.Yes)
                            FindUpdate();
                        else
                            Application.Exit();
                        if (MessageBox.Show("Extraction complete!", "Extraction complete", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) { System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"..\..\Steam Desktop Authenticator.exe"); Application.Exit(); }
                    }
                }

            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("There was an error while extracting the update. (Extraction failed)." + Environment.NewLine + ex.Message, "Error while extracting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                    Application.Exit();
            }

            //Complete
            if (MessageBox.Show("Extraction complete!", "Extraction complete", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) { System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"..\..\Steam Desktop Authenticator.exe"); Application.Exit(); }
        }


        private void FindUpdate()
        {
            MessageBox.Show("Please select the location of SDA");

            FolderBrowserDialog theFolder = new FolderBrowserDialog();
            theFolder.Description = "Select where you store SDA";
            //theFolder.RootFolder = Directory.GetCurrentDirectory();
            theFolder.ShowNewFolderButton = false;
            if (theFolder.ShowDialog() == DialogResult.OK)
            {
                extractTo = theFolder.SelectedPath.ToString();
            }

            MessageBox.Show("Please select the location of the update file");

            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select the update file";
            theDialog.Filter = "Update files (zips)|*.zip";
            theDialog.InitialDirectory = extractTo;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                var archive = ZipFile.OpenRead(theDialog.FileName.ToString());
                statusBar.Maximum = archive.Entries.Count - 1;
                statusBar.Minimum = 0;
                for (int i = 0; i < archive.Entries.Count - 1; i++)
                {
                    try
                    {
                        ZipArchiveEntry entry = archive.Entries[i];
                        if (entry.FullName == System.AppDomain.CurrentDomain.FriendlyName || entry.FullName.EndsWith("/") || entry.FullName.EndsWith("\\"))
                            fileNames.Text = fileNames.Text + Environment.NewLine + "Can't extract: " + entry.FullName;
                        else
                        {
                            fileNames.Text = fileNames.Text + Environment.NewLine + "Extracting: " + entry.FullName;
                            if (File.Exists(extractTo + "\\" + entry.FullName))
                                System.IO.File.Delete(extractTo + "\\" + entry.FullName);
                            entry.ExtractToFile(extractTo + "\\" + entry.FullName);
                        }
                        statusBar.Value = i;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Error while extracting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                //Complete
            }
        }
    }
}
