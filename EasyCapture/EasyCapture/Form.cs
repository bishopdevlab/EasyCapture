using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCapture
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Timer myTopmostChecker;
        private Rectangle myCaptureArea;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            myTopmostChecker = new Timer();
            myTopmostChecker.Tick += MyTopmostChecker_Tick;
            myTopmostChecker.Interval = 500;
            myTopmostChecker.Start();

            SelectScreen(ScreenPrimary.Name);
        }

        private void MyTopmostChecker_Tick(object sender, EventArgs e)
        {
            ChangeTopMost();
        }

        private void ChangeTopMost()
        {
            this.TopMost = true;
            this.Focus();
            this.BringToFront();
            this.TopMost = false;
        }

        private void Capture_Click(object sender, EventArgs e)
        {
            myTopmostChecker.Stop();
            this.Hide();
            CaptureScreen();
            this.Show();
            myTopmostChecker.Start();
        }

        private void CaptureScreen()
        {
            try
            {
                var directory = @"d:\Capture";
                var fileName = string.Format("{0}.png", numericFileName.Value);
                var filePath = Path.Combine(directory, fileName);

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                Rectangle s_rect = myCaptureArea;
                using (Bitmap bmp = new Bitmap(s_rect.Width, s_rect.Height))
                {
                    using (Graphics gScreen = Graphics.FromImage(bmp))
                        gScreen.CopyFromScreen(s_rect.Location, Point.Empty, s_rect.Size);
                    bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Screen_CheckedChanged(object sender, EventArgs e)
        {
            var selectedRadioButton = (sender as RadioButton);
            
            if (selectedRadioButton.Checked == true)
                SelectScreen(selectedRadioButton.Name);
        }

        private void SelectScreen(string targetScreen)
        {
            switch (targetScreen)
            {
                case "ScreenAll":
                    if (Screen.AllScreens.Length == 1)
                        myCaptureArea = Screen.PrimaryScreen.Bounds;
                    if (Screen.AllScreens.Length > 1)
                    {
                        // L/R
                        var left = Screen.AllScreens[0].Bounds.Left;
                        var top = Screen.AllScreens[0].Bounds.Top;
                        var righ = Screen.AllScreens[1].Bounds.Right;
                        var bottom = Screen.AllScreens[1].Bounds.Bottom;
                        myCaptureArea = new Rectangle(left, top, righ - left, bottom - top);

                        // U/D
                        //var left = Screen.AllScreens[0].Bounds.Left;
                        //var top = Screen.AllScreens[0].Bounds.Top;
                        //var righ = Screen.AllScreens[0].Bounds.Right;
                        //var bottom = Screen.AllScreens[1].Bounds.Bottom;
                        //myCaptureArea = new Rectangle(left, top, righ - left, bottom - top);
                    }
                    break;
                case "ScreenPrimary":
                    myCaptureArea = Screen.PrimaryScreen.Bounds;
                    break;
                case "ScreenSecondary":
                    if (Screen.AllScreens.Length == 1)
                    {
                        ScreenPrimary.Checked = true;
                        break;
                    }
                    myCaptureArea = Screen.AllScreens[1].Bounds;
                    break;
                default:
                    break;
            }
        }
    }
}
