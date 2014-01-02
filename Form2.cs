using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sharpGIFs_2._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Animated gif";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "/theGIF.gif");
            this.Height = 80 + Image.FromFile(Application.StartupPath + "/theGIF.gif").Height;
            this.Width = 70 + Image.FromFile(Application.StartupPath + "/theGIF.gif").Width;
        }
    }
}
