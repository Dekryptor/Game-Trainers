﻿namespace Trainer_Manager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dlprogressLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.adBrowser = new System.Windows.Forms.WebBrowser();
            this.centerNews = new System.Windows.Forms.WebBrowser();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.otherSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamSaveBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bingRewardsBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTrainerMemorydllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.browseFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.visitWeb = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 602);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ct_MouseDown);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(200, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 20);
            this.textBox1.TabIndex = 99;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 25);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.progressBar1.Location = new System.Drawing.Point(200, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(512, 25);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            // 
            // dlprogressLabel
            // 
            this.dlprogressLabel.AutoSize = true;
            this.dlprogressLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dlprogressLabel.Location = new System.Drawing.Point(718, 12);
            this.dlprogressLabel.Name = "dlprogressLabel";
            this.dlprogressLabel.Size = new System.Drawing.Size(80, 13);
            this.dlprogressLabel.TabIndex = 4;
            this.dlprogressLabel.Text = "Nothing to do...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.visitWeb);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dlprogressLabel);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 656);
            this.panel1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(983, 38);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(647, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "BROWSE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.minimizeButton);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.aboutButton);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 30);
            this.panel2.TabIndex = 7;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // aboutButton
            // 
            this.aboutButton.AccessibleDescription = "About Trainer Manager";
            this.aboutButton.AccessibleName = "About Button";
            this.aboutButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.Lavender;
            this.aboutButton.Location = new System.Drawing.Point(855, 4);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(40, 23);
            this.aboutButton.TabIndex = 10;
            this.aboutButton.Text = "?";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Lavender;
            this.button4.Location = new System.Drawing.Point(721, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 20);
            this.button4.TabIndex = 9;
            this.button4.Text = "OPEN";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSlateGray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(776, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 8;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adBrowser
            // 
            this.adBrowser.Location = new System.Drawing.Point(369, -36);
            this.adBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.adBrowser.Name = "adBrowser";
            this.adBrowser.ScriptErrorsSuppressed = true;
            this.adBrowser.ScrollBarsEnabled = false;
            this.adBrowser.Size = new System.Drawing.Size(628, 760);
            this.adBrowser.TabIndex = 8;
            this.adBrowser.Url = new System.Uri("https://newagesoldier.com/thanks-for-using-new-age-soldier-cheat-trainers/", System.UriKind.Absolute);
            this.adBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebDocumentCompleted);
            // 
            // centerNews
            // 
            this.centerNews.Location = new System.Drawing.Point(200, 30);
            this.centerNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.centerNews.Name = "centerNews";
            this.centerNews.ScriptErrorsSuppressed = true;
            this.centerNews.Size = new System.Drawing.Size(596, 632);
            this.centerNews.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Cheat Trainer Manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherSoftwareToolStripMenuItem,
            this.closeSoftwareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            // 
            // otherSoftwareToolStripMenuItem
            // 
            this.otherSoftwareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steamSaveBackupToolStripMenuItem,
            this.bingRewardsBotToolStripMenuItem,
            this.gameTrainerMemorydllToolStripMenuItem});
            this.otherSoftwareToolStripMenuItem.Name = "otherSoftwareToolStripMenuItem";
            this.otherSoftwareToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.otherSoftwareToolStripMenuItem.Text = "Other Software";
            // 
            // steamSaveBackupToolStripMenuItem
            // 
            this.steamSaveBackupToolStripMenuItem.Name = "steamSaveBackupToolStripMenuItem";
            this.steamSaveBackupToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.steamSaveBackupToolStripMenuItem.Text = "SteamSaveBackup";
            this.steamSaveBackupToolStripMenuItem.Click += new System.EventHandler(this.steamSaveBackupToolStripMenuItem_Click);
            // 
            // bingRewardsBotToolStripMenuItem
            // 
            this.bingRewardsBotToolStripMenuItem.Name = "bingRewardsBotToolStripMenuItem";
            this.bingRewardsBotToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.bingRewardsBotToolStripMenuItem.Text = "Bing Rewards Bot";
            this.bingRewardsBotToolStripMenuItem.Click += new System.EventHandler(this.bingRewardsBotToolStripMenuItem_Click);
            // 
            // gameTrainerMemorydllToolStripMenuItem
            // 
            this.gameTrainerMemorydllToolStripMenuItem.Name = "gameTrainerMemorydllToolStripMenuItem";
            this.gameTrainerMemorydllToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.gameTrainerMemorydllToolStripMenuItem.Text = "Game Trainer memory.dll";
            this.gameTrainerMemorydllToolStripMenuItem.Click += new System.EventHandler(this.gameTrainerMemorydllToolStripMenuItem_Click);
            // 
            // closeSoftwareToolStripMenuItem
            // 
            this.closeSoftwareToolStripMenuItem.Name = "closeSoftwareToolStripMenuItem";
            this.closeSoftwareToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.closeSoftwareToolStripMenuItem.Text = "Close Program";
            this.closeSoftwareToolStripMenuItem.Click += new System.EventHandler(this.closeSoftwareToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 630);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Game Cheat Trainers";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseFolderToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(149, 26);
            // 
            // browseFolderToolStripMenuItem
            // 
            this.browseFolderToolStripMenuItem.Name = "browseFolderToolStripMenuItem";
            this.browseFolderToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.browseFolderToolStripMenuItem.Text = "Browse Folder";
            this.browseFolderToolStripMenuItem.Click += new System.EventHandler(this.browseFolderToolStripMenuItem_Click);
            // 
            // closeButton
            // 
            this.closeButton.AccessibleDescription = "Close Trainer Manager";
            this.closeButton.AccessibleName = "Close Button";
            this.closeButton.BackColor = System.Drawing.Color.RosyBrown;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(939, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.AccessibleDescription = "Minimize Trainer Manager";
            this.minimizeButton.AccessibleName = "Minimize Button";
            this.minimizeButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.Lavender;
            this.minimizeButton.Location = new System.Drawing.Point(897, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(40, 23);
            this.minimizeButton.TabIndex = 12;
            this.minimizeButton.Tag = "";
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Game Trainer Manager";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // visitWeb
            // 
            this.visitWeb.BackColor = System.Drawing.Color.SteelBlue;
            this.visitWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visitWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitWeb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.visitWeb.Location = new System.Drawing.Point(815, 6);
            this.visitWeb.Name = "visitWeb";
            this.visitWeb.Size = new System.Drawing.Size(162, 25);
            this.visitWeb.TabIndex = 5;
            this.visitWeb.Text = "visit newagesoldier.com";
            this.visitWeb.UseVisualStyleBackColor = false;
            this.visitWeb.Click += new System.EventHandler(this.visitWeb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(983, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.centerNews);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.adBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheat Trainer Manager :: http://newagesoldier.com";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label dlprogressLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.WebBrowser adBrowser;
        private System.Windows.Forms.WebBrowser centerNews;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem otherSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steamSaveBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bingRewardsBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameTrainerMemorydllToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem browseFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeSoftwareToolStripMenuItem;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button visitWeb;
    }
}

