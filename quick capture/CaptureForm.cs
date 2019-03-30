using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace quick_capture
{
    public partial class CaptureForm : Form
    {
        public CaptureForm()
        {
            InitializeComponent();
        }

        public int frames = 0;
        Bitmap screenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        string fileExtension = ".png";
        ImageFormat fileType = ImageFormat.Png;

        string filename;

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            string videoFolder = @"C:\Users\" + Environment.UserName + @"\Videos\";
            if(Directory.Exists(videoFolder))
                outputFolderInput.Text = videoFolder;
        }

        public void capture()
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            var gfxScreenshot = Graphics.FromImage(screenCapture);
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);
            //save
            screenCapture.Save(outputFolderInput.Text + filename.Replace("$n", frames.ToString()), fileType);
            frames++;
        }

        private void captureTimer_Tick(object sender, EventArgs e)
        {
            capture();
        }

        private void maximizeMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            if (captureButton.Text == "Capture!") //i wrote this years ago but it works so i can't be bothered to change it
            {

                //fix input folder
                if (!outputFolderInput.Text.EndsWith("\\"))
                {
                    outputFolderInput.Text += "\\";
                }
                filename = outputNameInput.Text + fileExtension;

                //set file extension
                fileExtension = fileTypeDropdown.Text;
                switch (fileTypeDropdown.Text)
                {
                    case ".png":
                        fileType = ImageFormat.Png;
                        break;
                    case ".jpg":
                        fileType = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        fileType = ImageFormat.Bmp;
                        break;
                    case ".gif":
                        fileType = ImageFormat.Gif;
                        break;
                    default:
                        fileType = ImageFormat.Png;
                        break;
                }

                int framerate = Convert.ToInt32(framerateInput.Text);
                //set timer
                switch (timerModeDropdown.Text)
                {
                    case "FPS":
                        captureTimer.Interval = 1000 / framerate;
                        break;
                    case "second delay":
                        captureTimer.Interval = 1000 * framerate;
                        break;
                }

                captureTimer.Start();
                captureButton.Text = "Stop Capture";
                captureMenuItem.Text = "Stop Capture";
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                captureTimer.Stop();
                captureButton.Text = "Capture!";
                captureMenuItem.Text = "Capture!";
            }
        }

        private void captureMenuItem_Click(object sender, EventArgs e)
        {
            if (captureMenuItem.Text == "Start Capture")
            {
                captureButton.Text = "Stop Capture";
                captureMenuItem.Text = "Stop Capture";
                captureTimer.Start();
            }
            else
            {
                captureButton.Text = "Capture!";
                captureMenuItem.Text = "Start Capture";
                captureTimer.Stop();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Choose a folder, captured images will be saved here.";
            folderBrowser.ShowNewFolderButton = true;
            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                outputFolderInput.Text = folderBrowser.SelectedPath;
            }
        }
    }
}
