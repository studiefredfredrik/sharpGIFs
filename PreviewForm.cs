using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace sharpGIFs_2._0
{
    public partial class PreviewForm : Form
    {
        public PreviewForm()
        {
            InitializeComponent();
            this.Text = "Animated gif";
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "/theGIF.gif");

            Image gifImg; 
            // Have to make sure the file is released afterwards
            using (FileStream stream = new FileStream(Application.StartupPath + "/theGIF.gif", FileMode.Open, FileAccess.Read))
            {
                gifImg = Image.FromStream(stream);
            }
            this.Height = 80 + gifImg.Height;
            this.Width = 70 + gifImg.Width;

        }

        private void PreviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Properly dispose the viewer
            webBrowser1.Navigate(new Uri("about:blank"));
            webBrowser1.DocumentText = "";
        }
    }
}
