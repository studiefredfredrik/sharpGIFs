using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace sharpGIFs_2._0
{
    public partial class MainForm : Form
    {
        //Setting global variables
        int newWidth = 400;
        byte frameDelayLow = 9;
        byte frameDelayHigh = 0;
        byte transparencyIndex = 255;
        List<Image> thumbsList = new List<Image>();
        int currentImage = 0;
        string theGIFpath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectImages_Click(object sender, EventArgs e)
        {
            try
            {
                newWidth = Convert.ToInt32(txtWidth.Text);
                OpenFileDialog b = new OpenFileDialog();
                b.Multiselect = true;
                b.Title = "Select some images";
                DialogResult dr = b.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    thumbsList.Clear(); // clear list before adding new images
                    // Read the files
                    foreach (String file in b.FileNames)
                    {
                        thumbsList.Add(BitmapThumbs(file));
                    }
                    picboxImgPreview.Image = thumbsList[0].GetThumbnailImage(picboxImgPreview.Width, picboxImgPreview.Height, 
                        null, IntPtr.Zero);
                    currentImage = 0;
                    btnPreviewNxt.Enabled = true;
                    lblImageNumber.Text = (currentImage + 1) + " / " + thumbsList.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            theGIFpath = Application.StartupPath + "/theGIF.gif";
            btnPreviewNxt.Enabled = false;
            btnPreviewPrv.Enabled = false;
            lblImageNumber.Text = "0 / " + thumbsList.Count;
        }

        public void CreateGIF_File(List<Image> thumbs, string path)
        {
            try
            {
                //Variable declaration
                MemoryStream memoryStream;
                BinaryWriter binaryWriter;
                Image image;
                Byte[] buf1;
                Byte[] buf2;
                Byte[] buf3;
                //Variable declaration

                memoryStream = new MemoryStream();
                buf2 = new Byte[19];
                buf3 = new Byte[8];
                buf2[0] = 33;  //extension introducer
                buf2[1] = 255; //application extension
                buf2[2] = 11;  //size of block
                buf2[3] = 78;  //N
                buf2[4] = 69;  //E
                buf2[5] = 84;  //T
                buf2[6] = 83;  //S
                buf2[7] = 67;  //C
                buf2[8] = 65;  //A
                buf2[9] = 80;  //P
                buf2[10] = 69; //E
                buf2[11] = 50; //2
                buf2[12] = 46; //.
                buf2[13] = 48; //0
                buf2[14] = 3;  //Size of block
                buf2[15] = 1;  //
                buf2[16] = 0;  //
                buf2[17] = 0;  //
                buf2[18] = 0;  //Block terminator
                buf3[0] = 33;  //Extension introducer
                buf3[1] = 249; //Graphic control extension
                buf3[2] = 4;   //Size of block
                buf3[3] = 9;   //Flags: reserved, disposal method, user input, transparent color
                buf3[4] = frameDelayLow;    //Delay time low byte
                buf3[5] = frameDelayHigh;   //Delay time high byte
                buf3[6] = transparencyIndex;    //Transparent color index
                buf3[7] = 0;   //Block terminator
                binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create));

                for (int picCount = 0; picCount < thumbs.Count; picCount++)
                {
                    image = thumbs[picCount];
                    image.Save(memoryStream, ImageFormat.Gif);
                    buf1 = memoryStream.ToArray();

                    if (picCount == 0)
                    {
                        //only write these the first time....
                        binaryWriter.Write(buf1, 0, 781); //Header & global color table
                        binaryWriter.Write(buf2, 0, 19); //Application extension
                    }

                    binaryWriter.Write(buf3, 0, 8); //Graphic extension
                    binaryWriter.Write(buf1, 789, buf1.Length - 790); //Image data

                    if (picCount == thumbs.Count - 1)
                    {
                        //only write this one the last time....
                        binaryWriter.Write(";"); //Image terminator
                    }
                    memoryStream.SetLength(0);
                }
                binaryWriter.Close();
                memoryStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Image CreateGIF_inStream(List<Image> thumbs)
        {
            try
            {
                //Variable declaration
                MemoryStream memoryStream;
                BinaryWriter binaryWriter;
                Image image;
                Byte[] buf1;
                Byte[] buf2;
                Byte[] buf3;
                //Variable declaration

                MemoryStream stream = new MemoryStream();

                memoryStream = new MemoryStream();
                buf2 = new Byte[19];
                buf3 = new Byte[8];
                buf2[0] = 33;  //extension introducer
                buf2[1] = 255; //application extension
                buf2[2] = 11;  //size of block
                buf2[3] = 78;  //N
                buf2[4] = 69;  //E
                buf2[5] = 84;  //T
                buf2[6] = 83;  //S
                buf2[7] = 67;  //C
                buf2[8] = 65;  //A
                buf2[9] = 80;  //P
                buf2[10] = 69; //E
                buf2[11] = 50; //2
                buf2[12] = 46; //.
                buf2[13] = 48; //0
                buf2[14] = 3;  //Size of block
                buf2[15] = 1;  //
                buf2[16] = 0;  //
                buf2[17] = 0;  //
                buf2[18] = 0;  //Block terminator
                buf3[0] = 33;  //Extension introducer
                buf3[1] = 249; //Graphic control extension
                buf3[2] = 4;   //Size of block
                buf3[3] = 9;   //Flags: reserved, disposal method, user input, transparent color
                buf3[4] = 9;  //Delay time low byte
                buf3[5] = 0;   //Delay time high byte
                buf3[6] = 255; //Transparent color index
                buf3[7] = 0;   //Block terminator
                binaryWriter = new BinaryWriter(stream);
                for (int picCount = 0; picCount < thumbs.Count; picCount++)
                {
                    image = thumbs[picCount];
                    image.Save(memoryStream, ImageFormat.Gif);
                    buf1 = memoryStream.ToArray();

                    if (picCount == 0)
                    {
                        //only write these the first time....
                        binaryWriter.Write(buf1, 0, 781); //Header & global color table
                        binaryWriter.Write(buf2, 0, 19); //Application extension
                    }

                    binaryWriter.Write(buf3, 0, 8); //Graphic extension
                    binaryWriter.Write(buf1, 789, buf1.Length - 790); //Image data

                    if (picCount == thumbs.Count - 1)
                    {
                        //only write this one the last time....
                        binaryWriter.Write(";"); //Image terminator
                    }
                    memoryStream.SetLength(0);
                }
                binaryWriter.Close();
                Image streamGIF = Image.FromStream(stream);
                stream.Close();
                return streamGIF;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Image.FromFile(theGIFpath);
            }
        }
        public Image BitmapThumbs(string path)
        {
                Image originalImage = System.Drawing.Image.FromFile(path);
                Image resizedImage = originalImage.GetThumbnailImage(newWidth, (newWidth * originalImage.Height) / 
                    originalImage.Width, null, IntPtr.Zero);
                return resizedImage;
        }

        private void btnPreviewNxt_Click(object sender, EventArgs e)
        {
            if (thumbsList.Count > 0)
            {
                if (currentImage <= thumbsList.Count - 1)
                {
                    currentImage++;
                    if (currentImage <= thumbsList.Count - 1)
                    {
                        picboxImgPreview.Image = thumbsList[currentImage].GetThumbnailImage(picboxImgPreview.Width, picboxImgPreview.Height,
                            null, IntPtr.Zero);
                    }
                }
                if (currentImage == thumbsList.Count - 1) btnPreviewNxt.Enabled = false;
                if (currentImage >= 1 && thumbsList.Count > 0) btnPreviewPrv.Enabled = true;
            }
            lblImageNumber.Text = (currentImage + 1) + " / " + thumbsList.Count;
        }

        private void btnPreviewPrv_Click(object sender, EventArgs e)
        {
            if (thumbsList.Count > 0)
            {
                if (currentImage >= 1)
                {
                    currentImage--;
                    picboxImgPreview.Image = thumbsList[currentImage].GetThumbnailImage(picboxImgPreview.Width, picboxImgPreview.Height,
                        null, IntPtr.Zero); ;
                }
                if (currentImage == 0) btnPreviewPrv.Enabled = false;
                if (currentImage < thumbsList.Count - 1) btnPreviewNxt.Enabled = true;
            }
            lblImageNumber.Text = (currentImage + 1) + " / " + thumbsList.Count;
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            if (thumbsList.Count > 0)
            {
                if (thumbsList[currentImage] != null) thumbsList.RemoveAt(currentImage);
                if (currentImage > 0) currentImage--;
                if (thumbsList.Count > 1)
                {
                    picboxImgPreview.Image = thumbsList[currentImage].GetThumbnailImage(picboxImgPreview.Width, picboxImgPreview.Height,
                        null, IntPtr.Zero);
                }
                if (thumbsList.Count == 0)
                {
                    picboxImgPreview.Image = picboxImgPreview.InitialImage;
                    lblImageNumber.Text = "0 / " + thumbsList.Count;
                }
            }
            if(thumbsList.Count > 0) lblImageNumber.Text = (currentImage + 1) + " / " + thumbsList.Count;
            if (currentImage < thumbsList.Count - 1 && thumbsList.Count > 0) btnPreviewNxt.Enabled = true;
            if (currentImage > 1 && thumbsList.Count > 0) btnPreviewPrv.Enabled = true;
            if (thumbsList.Count == 0) { btnPreviewNxt.Enabled = false; btnPreviewPrv.Enabled = false; }
            if (currentImage > thumbsList.Count - 1) btnPreviewNxt.Enabled = false;
            if (currentImage < 1) btnPreviewPrv.Enabled = false;
        }
        private void btnCreateGIF_Click(object sender, EventArgs e)
        {
            if (thumbsList.Count == 0) return; 

            // It works, but having threading and async reading wouldn't hurt
            try
            {
                newWidth = Convert.ToInt32(txtWidth.Text);
                frameDelayHigh = Convert.ToByte(txtHighByte.Text);
                frameDelayLow = Convert.ToByte(txtLowByte.Text);
                transparencyIndex = Convert.ToByte(txtTransparencyIndex.Text);
                if (File.Exists(theGIFpath)) File.Delete(theGIFpath);
                CreateGIF_File(thumbsList, theGIFpath);
                PreviewForm n = new PreviewForm();
                n.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
