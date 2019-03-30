namespace quick_capture
{
    partial class CaptureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.captureMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureTimer = new System.Windows.Forms.Timer(this.components);
            this.outputFolderLabel = new System.Windows.Forms.Label();
            this.outputFolderInput = new System.Windows.Forms.TextBox();
            this.outputNameLabel = new System.Windows.Forms.Label();
            this.outputNameInput = new System.Windows.Forms.TextBox();
            this.outputAlertLabel = new System.Windows.Forms.Label();
            this.captureButton = new System.Windows.Forms.Button();
            this.minimizeAlertLabel = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.fileTypeDropdown = new System.Windows.Forms.ComboBox();
            this.framerateLabel = new System.Windows.Forms.Label();
            this.framerateInput = new System.Windows.Forms.TextBox();
            this.timerModeDropdown = new System.Windows.Forms.ComboBox();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "quick capture";
            this.notifyIcon.Visible = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureMenuItem,
            this.maximizeMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(144, 48);
            this.contextMenu.Text = "quick capture";
            // 
            // captureMenuItem
            // 
            this.captureMenuItem.Name = "captureMenuItem";
            this.captureMenuItem.Size = new System.Drawing.Size(143, 22);
            this.captureMenuItem.Text = "Start Capture";
            this.captureMenuItem.Click += new System.EventHandler(this.captureMenuItem_Click);
            // 
            // maximizeMenuItem
            // 
            this.maximizeMenuItem.Name = "maximizeMenuItem";
            this.maximizeMenuItem.Size = new System.Drawing.Size(143, 22);
            this.maximizeMenuItem.Text = "Maximize";
            this.maximizeMenuItem.Click += new System.EventHandler(this.maximizeMenuItem_Click);
            // 
            // captureTimer
            // 
            this.captureTimer.Interval = 33;
            this.captureTimer.Tick += new System.EventHandler(this.captureTimer_Tick);
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.AutoSize = true;
            this.outputFolderLabel.Location = new System.Drawing.Point(10, 15);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(71, 13);
            this.outputFolderLabel.TabIndex = 4;
            this.outputFolderLabel.Text = "Ouput Folder:";
            // 
            // outputFolderInput
            // 
            this.outputFolderInput.Location = new System.Drawing.Point(87, 12);
            this.outputFolderInput.Name = "outputFolderInput";
            this.outputFolderInput.Size = new System.Drawing.Size(323, 20);
            this.outputFolderInput.TabIndex = 5;
            // 
            // outputNameLabel
            // 
            this.outputNameLabel.AutoSize = true;
            this.outputNameLabel.Location = new System.Drawing.Point(10, 38);
            this.outputNameLabel.Name = "outputNameLabel";
            this.outputNameLabel.Size = new System.Drawing.Size(73, 13);
            this.outputNameLabel.TabIndex = 6;
            this.outputNameLabel.Text = "Output Name:";
            // 
            // outputNameInput
            // 
            this.outputNameInput.Location = new System.Drawing.Point(87, 35);
            this.outputNameInput.Name = "outputNameInput";
            this.outputNameInput.Size = new System.Drawing.Size(166, 20);
            this.outputNameInput.TabIndex = 7;
            this.outputNameInput.Text = "capture_$n";
            // 
            // outputAlertLabel
            // 
            this.outputAlertLabel.AutoSize = true;
            this.outputAlertLabel.Location = new System.Drawing.Point(323, 38);
            this.outputAlertLabel.Name = "outputAlertLabel";
            this.outputAlertLabel.Size = new System.Drawing.Size(77, 13);
            this.outputAlertLabel.TabIndex = 8;
            this.outputAlertLabel.Text = "($n = frame ID)";
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(13, 85);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(159, 34);
            this.captureButton.TabIndex = 9;
            this.captureButton.Text = "Capture!";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // minimizeAlertLabel
            // 
            this.minimizeAlertLabel.AutoSize = true;
            this.minimizeAlertLabel.Location = new System.Drawing.Point(178, 96);
            this.minimizeAlertLabel.Name = "minimizeAlertLabel";
            this.minimizeAlertLabel.Size = new System.Drawing.Size(231, 13);
            this.minimizeAlertLabel.TabIndex = 10;
            this.minimizeAlertLabel.Text = "This window will be minimized to the system tray";
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(415, 85);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(32, 34);
            this.logoBox.TabIndex = 11;
            this.logoBox.TabStop = false;
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.Location = new System.Drawing.Point(416, 10);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(25, 23);
            this.chooseFolderButton.TabIndex = 12;
            this.chooseFolderButton.Text = "...";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // fileTypeDropdown
            // 
            this.fileTypeDropdown.FormattingEnabled = true;
            this.fileTypeDropdown.Items.AddRange(new object[] {
            ".png",
            ".jpg",
            ".bmp",
            ".gif"});
            this.fileTypeDropdown.Location = new System.Drawing.Point(259, 35);
            this.fileTypeDropdown.Name = "fileTypeDropdown";
            this.fileTypeDropdown.Size = new System.Drawing.Size(58, 21);
            this.fileTypeDropdown.TabIndex = 13;
            this.fileTypeDropdown.Text = ".png";
            // 
            // framerateLabel
            // 
            this.framerateLabel.AutoSize = true;
            this.framerateLabel.Location = new System.Drawing.Point(10, 61);
            this.framerateLabel.Name = "framerateLabel";
            this.framerateLabel.Size = new System.Drawing.Size(57, 13);
            this.framerateLabel.TabIndex = 14;
            this.framerateLabel.Text = "Framerate:";
            // 
            // framerateInput
            // 
            this.framerateInput.Location = new System.Drawing.Point(87, 58);
            this.framerateInput.Name = "framerateInput";
            this.framerateInput.Size = new System.Drawing.Size(65, 20);
            this.framerateInput.TabIndex = 15;
            this.framerateInput.Text = "30";
            // 
            // timerModeDropdown
            // 
            this.timerModeDropdown.FormattingEnabled = true;
            this.timerModeDropdown.Items.AddRange(new object[] {
            "FPS",
            "second delay"});
            this.timerModeDropdown.Location = new System.Drawing.Point(158, 58);
            this.timerModeDropdown.Name = "timerModeDropdown";
            this.timerModeDropdown.Size = new System.Drawing.Size(95, 21);
            this.timerModeDropdown.TabIndex = 16;
            this.timerModeDropdown.Text = "FPS";
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 126);
            this.Controls.Add(this.timerModeDropdown);
            this.Controls.Add(this.framerateInput);
            this.Controls.Add(this.framerateLabel);
            this.Controls.Add(this.fileTypeDropdown);
            this.Controls.Add(this.chooseFolderButton);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.minimizeAlertLabel);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.outputAlertLabel);
            this.Controls.Add(this.outputNameInput);
            this.Controls.Add(this.outputNameLabel);
            this.Controls.Add(this.outputFolderInput);
            this.Controls.Add(this.outputFolderLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CaptureForm";
            this.ShowIcon = false;
            this.Text = "quick capture";
            this.Load += new System.EventHandler(this.CaptureForm_Load);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem captureMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizeMenuItem;
        private System.Windows.Forms.Timer captureTimer;
        private System.Windows.Forms.Label outputFolderLabel;
        private System.Windows.Forms.TextBox outputFolderInput;
        private System.Windows.Forms.Label outputNameLabel;
        private System.Windows.Forms.TextBox outputNameInput;
        private System.Windows.Forms.Label outputAlertLabel;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Label minimizeAlertLabel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.ComboBox fileTypeDropdown;
        private System.Windows.Forms.Label framerateLabel;
        private System.Windows.Forms.TextBox framerateInput;
        private System.Windows.Forms.ComboBox timerModeDropdown;
    }
}

