﻿namespace telegram_exporter
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonCheckForTelegramData = new System.Windows.Forms.Button();
            this.textBoxAdbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogAdbSelector = new System.Windows.Forms.OpenFileDialog();
            this.buttonSelectAdb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOutDir = new System.Windows.Forms.TextBox();
            this.buttonSelectOutDir = new System.Windows.Forms.Button();
            this.folderBrowserDialogOutDirSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBarCopy = new System.Windows.Forms.ProgressBar();
            this.buttonDetectDevices = new System.Windows.Forms.Button();
            this.buttonCopyData = new System.Windows.Forms.Button();
            this.labelDetectedDevices = new System.Windows.Forms.Label();
            this.labelTelegramDataCheck = new System.Windows.Forms.Label();
            this.labelCopyData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCheckForTelegramData
            // 
            this.buttonCheckForTelegramData.Enabled = false;
            this.buttonCheckForTelegramData.Location = new System.Drawing.Point(344, 225);
            this.buttonCheckForTelegramData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCheckForTelegramData.Name = "buttonCheckForTelegramData";
            this.buttonCheckForTelegramData.Size = new System.Drawing.Size(267, 43);
            this.buttonCheckForTelegramData.TabIndex = 7;
            this.buttonCheckForTelegramData.Text = "Check for Telegram Data";
            this.buttonCheckForTelegramData.UseVisualStyleBackColor = true;
            this.buttonCheckForTelegramData.Click += new System.EventHandler(this.buttonCheckForTelegramData_Click);
            // 
            // textBoxAdbPath
            // 
            this.textBoxAdbPath.Location = new System.Drawing.Point(32, 58);
            this.textBoxAdbPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAdbPath.Name = "textBoxAdbPath";
            this.textBoxAdbPath.Size = new System.Drawing.Size(775, 22);
            this.textBoxAdbPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to ADB.exe";
            // 
            // openFileDialogAdbSelector
            // 
            this.openFileDialogAdbSelector.FileName = "adb.exe";
            // 
            // buttonSelectAdb
            // 
            this.buttonSelectAdb.Location = new System.Drawing.Point(816, 55);
            this.buttonSelectAdb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectAdb.Name = "buttonSelectAdb";
            this.buttonSelectAdb.Size = new System.Drawing.Size(100, 28);
            this.buttonSelectAdb.TabIndex = 2;
            this.buttonSelectAdb.Text = "Browse";
            this.buttonSelectAdb.UseVisualStyleBackColor = true;
            this.buttonSelectAdb.Click += new System.EventHandler(this.buttonSelectAdb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Export directory path";
            // 
            // textBoxOutDir
            // 
            this.textBoxOutDir.Location = new System.Drawing.Point(32, 130);
            this.textBoxOutDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOutDir.Name = "textBoxOutDir";
            this.textBoxOutDir.Size = new System.Drawing.Size(775, 22);
            this.textBoxOutDir.TabIndex = 4;
            // 
            // buttonSelectOutDir
            // 
            this.buttonSelectOutDir.Location = new System.Drawing.Point(816, 128);
            this.buttonSelectOutDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectOutDir.Name = "buttonSelectOutDir";
            this.buttonSelectOutDir.Size = new System.Drawing.Size(100, 28);
            this.buttonSelectOutDir.TabIndex = 5;
            this.buttonSelectOutDir.Text = "Browse";
            this.buttonSelectOutDir.UseVisualStyleBackColor = true;
            this.buttonSelectOutDir.Click += new System.EventHandler(this.buttonSelectOutDir_Click);
            // 
            // progressBarCopy
            // 
            this.progressBarCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarCopy.Location = new System.Drawing.Point(32, 346);
            this.progressBarCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarCopy.MarqueeAnimationSpeed = 10;
            this.progressBarCopy.Name = "progressBarCopy";
            this.progressBarCopy.Size = new System.Drawing.Size(884, 28);
            this.progressBarCopy.Step = 1;
            this.progressBarCopy.TabIndex = 100;
            // 
            // buttonDetectDevices
            // 
            this.buttonDetectDevices.Enabled = false;
            this.buttonDetectDevices.Location = new System.Drawing.Point(32, 225);
            this.buttonDetectDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDetectDevices.Name = "buttonDetectDevices";
            this.buttonDetectDevices.Size = new System.Drawing.Size(267, 43);
            this.buttonDetectDevices.TabIndex = 6;
            this.buttonDetectDevices.Text = "Detect available Devices";
            this.buttonDetectDevices.UseVisualStyleBackColor = true;
            this.buttonDetectDevices.Click += new System.EventHandler(this.buttonDetectDevices_Click);
            // 
            // buttonCopyData
            // 
            this.buttonCopyData.Enabled = false;
            this.buttonCopyData.Location = new System.Drawing.Point(649, 225);
            this.buttonCopyData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCopyData.Name = "buttonCopyData";
            this.buttonCopyData.Size = new System.Drawing.Size(267, 43);
            this.buttonCopyData.TabIndex = 8;
            this.buttonCopyData.Text = "Copy Data to Local Machine";
            this.buttonCopyData.UseVisualStyleBackColor = true;
            this.buttonCopyData.Click += new System.EventHandler(this.buttonCopyData_Click);
            // 
            // labelDetectedDevices
            // 
            this.labelDetectedDevices.AutoSize = true;
            this.labelDetectedDevices.Location = new System.Drawing.Point(28, 283);
            this.labelDetectedDevices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetectedDevices.Name = "labelDetectedDevices";
            this.labelDetectedDevices.Size = new System.Drawing.Size(45, 16);
            this.labelDetectedDevices.TabIndex = 9;
            this.labelDetectedDevices.Text = "Empty";
            // 
            // labelTelegramDataCheck
            // 
            this.labelTelegramDataCheck.AutoSize = true;
            this.labelTelegramDataCheck.Location = new System.Drawing.Point(340, 283);
            this.labelTelegramDataCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelegramDataCheck.Name = "labelTelegramDataCheck";
            this.labelTelegramDataCheck.Size = new System.Drawing.Size(45, 16);
            this.labelTelegramDataCheck.TabIndex = 10;
            this.labelTelegramDataCheck.Text = "Empty";
            // 
            // labelCopyData
            // 
            this.labelCopyData.AutoSize = true;
            this.labelCopyData.Location = new System.Drawing.Point(645, 283);
            this.labelCopyData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCopyData.Name = "labelCopyData";
            this.labelCopyData.Size = new System.Drawing.Size(45, 16);
            this.labelCopyData.TabIndex = 11;
            this.labelCopyData.Text = "Empty";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 411);
            this.Controls.Add(this.labelCopyData);
            this.Controls.Add(this.labelTelegramDataCheck);
            this.Controls.Add(this.labelDetectedDevices);
            this.Controls.Add(this.buttonCopyData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDetectDevices);
            this.Controls.Add(this.textBoxAdbPath);
            this.Controls.Add(this.buttonSelectOutDir);
            this.Controls.Add(this.progressBarCopy);
            this.Controls.Add(this.buttonSelectAdb);
            this.Controls.Add(this.textBoxOutDir);
            this.Controls.Add(this.buttonCheckForTelegramData);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Telegram Data Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckForTelegramData;
        private System.Windows.Forms.TextBox textBoxAdbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialogAdbSelector;
        private System.Windows.Forms.Button buttonSelectAdb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOutDir;
        private System.Windows.Forms.Button buttonSelectOutDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutDirSelector;
        private System.Windows.Forms.ProgressBar progressBarCopy;
        private System.Windows.Forms.Button buttonDetectDevices;
        private System.Windows.Forms.Button buttonCopyData;
        private System.Windows.Forms.Label labelDetectedDevices;
        private System.Windows.Forms.Label labelTelegramDataCheck;
        private System.Windows.Forms.Label labelCopyData;
    }
}

