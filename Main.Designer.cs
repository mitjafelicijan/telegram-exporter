namespace telegram_exporter
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
            this.buttonCheckForTelegramData = new System.Windows.Forms.Button();
            this.textBoxAdbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogAdbSelector = new System.Windows.Forms.OpenFileDialog();
            this.buttonSelectAdb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCheckForTelegramData
            // 
            this.buttonCheckForTelegramData.Location = new System.Drawing.Point(426, 172);
            this.buttonCheckForTelegramData.Name = "buttonCheckForTelegramData";
            this.buttonCheckForTelegramData.Size = new System.Drawing.Size(217, 43);
            this.buttonCheckForTelegramData.TabIndex = 0;
            this.buttonCheckForTelegramData.Text = "Check for Telegram Data";
            this.buttonCheckForTelegramData.UseVisualStyleBackColor = true;
            this.buttonCheckForTelegramData.Click += new System.EventHandler(this.buttonCheckForTelegramData_Click);
            // 
            // textBoxAdbPath
            // 
            this.textBoxAdbPath.Location = new System.Drawing.Point(148, 307);
            this.textBoxAdbPath.Name = "textBoxAdbPath";
            this.textBoxAdbPath.Size = new System.Drawing.Size(372, 20);
            this.textBoxAdbPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path to ADB.exe";
            // 
            // openFileDialogAdbSelector
            // 
            this.openFileDialogAdbSelector.FileName = "adb.exe";
            this.openFileDialogAdbSelector.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogAdbSelector_FileOk);
            // 
            // buttonSelectAdb
            // 
            this.buttonSelectAdb.Location = new System.Drawing.Point(527, 303);
            this.buttonSelectAdb.Name = "buttonSelectAdb";
            this.buttonSelectAdb.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAdb.TabIndex = 3;
            this.buttonSelectAdb.Text = "Browse";
            this.buttonSelectAdb.UseVisualStyleBackColor = true;
            this.buttonSelectAdb.Click += new System.EventHandler(this.buttonSelectAdb_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSelectAdb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdbPath);
            this.Controls.Add(this.buttonCheckForTelegramData);
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
    }
}

