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
using static System.Windows.Forms.LinkLabel;

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

            string command = "devices";
            string compoundCommand = String.Format("/c {0} {1}", adbPathSetting, command);

            Console.WriteLine(compoundCommand);
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

            Console.WriteLine(response);

            return response;
        }

        private void buttonCheckForTelegramData_Click(object sender, EventArgs e)
        {
            string[] output = executeShellAndReturn("shell ls /sdcard/Telegram1");

            if (output.Length == 0)
            {
                Console.WriteLine("No Telegram Data detected!");
            }

            foreach (var line in output)
            {
                if (!line.StartsWith("List of"))
                {
                    Console.WriteLine(line);
                }
            }
        }

        private void buttonSelectAdb_Click(object sender, EventArgs e)
        {
            openFileDialogAdbSelector.ShowDialog();
        }

        private void openFileDialogAdbSelector_FileOk(object sender, CancelEventArgs e)
        {
            textBoxAdbPath.Text = openFileDialogAdbSelector.FileName;

            // Save for later uses.
            Properties.Settings.Default.AdbPath = openFileDialogAdbSelector.FileName;
            Properties.Settings.Default.Save();
        }
    }
}
