using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telegram_exporter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Re-populate adb text field if it was already set in the past.
            string adbPathSetting = Properties.Settings.Default.AdbPath;
            textBoxAdbPath.Text = adbPathSetting;

            // Re-populates out directory where export will store files.
            string outDirSetting = Properties.Settings.Default.OutDir;
            textBoxOutDir.Text = outDirSetting;

            // Shame: Resets empty labels.
            labelDetectedDevices.Text = "";
            labelTelegramDataCheck.Text = "";
            labelCopyData.Text = "";

            // Enable buttons if outdir or adb path are not selected.
            if (adbPathSetting.Length > 0)
            {
                buttonDetectDevices.Enabled = true;
            }            
        }

        private string[] executeShellAndReturn(string command)
        {
            string adbPathSetting = Properties.Settings.Default.AdbPath;
            string compoundCommand = String.Format("/c {0} {1}", adbPathSetting, command);

            var processStartInfo = new ProcessStartInfo("cmd", compoundCommand)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = new Process
            {
                StartInfo = processStartInfo
            };

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            string[] response = new string[] { };
            string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    Array.Resize(ref response, response.Length + 1);
                    response[response.Length - 1] = line;
                }
            }

            return response;
        }

        private async Task executeCopyCommand()
        {
            await Task.Run(() =>
            {
                string adbPathSetting = Properties.Settings.Default.AdbPath;
                string outDirSetting = Properties.Settings.Default.OutDir;
                string compoundCommand = String.Format("/c {0} pull -a -Z  /sdcard/Telegram {1}", adbPathSetting, outDirSetting);

                var processStartInfo = new ProcessStartInfo("cmd", compoundCommand)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                var process = new Process
                {
                    StartInfo = processStartInfo
                };

                process.Start();
                process.WaitForExit();
            });
        }

        private void buttonCheckForTelegramData_Click(object sender, EventArgs e)
        {
            string[] output = executeShellAndReturn("shell ls /sdcard/Telegram");

            if (output.Length == 0)
            {
                labelTelegramDataCheck.Text = "NO Telegram Data detected!";
            } else
            {
                labelTelegramDataCheck.Text = "Data was found on the device!";
                buttonCopyData.Enabled = true;
            }
        }

        private void buttonSelectAdb_Click(object sender, EventArgs e)
        {
            if (openFileDialogAdbSelector.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialogAdbSelector.FileName;

                // Sets the input field with the selected path.
                textBoxAdbPath.Text = selectedFile;

                // Save for later uses.
                Properties.Settings.Default.AdbPath = selectedFile;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonSelectOutDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogOutDirSelector.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderBrowserDialogOutDirSelector.SelectedPath;

                // Sets the input field with the selected path.
                textBoxOutDir.Text = selectedFolder;

                // Save for later uses.
                Properties.Settings.Default.OutDir = selectedFolder;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonDetectDevices_Click(object sender, EventArgs e)
        {
            string[] output = executeShellAndReturn("devices");

            if (output.Length == 0)
            {
                labelDetectedDevices.Text = "No devices detected!";
            } else
            {
                string firstDevice = "";
                foreach (var line in output)
                {
                    if (!line.StartsWith("List of"))
                    {
                        Console.WriteLine(line);
                        firstDevice = line;
                        break;
                    }
                }
            
                firstDevice = String.Format("Device found: {0}", firstDevice);

                int maxStringLength = 40;
                if (maxStringLength > firstDevice.Length)
                {
                    maxStringLength = firstDevice.Length;
                }

                labelDetectedDevices.Text = firstDevice.Substring(0, maxStringLength);
                buttonCheckForTelegramData.Enabled = true;
            }
        }

        private async void buttonCopyData_Click(object sender, EventArgs e)
        {
            progressBarCopy.Style = ProgressBarStyle.Marquee;
            await executeCopyCommand();
            progressBarCopy.Style = ProgressBarStyle.Blocks;

            MessageBox.Show("Data was copied to your local machine.", "Operation finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
