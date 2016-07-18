namespace sharpGIFs_2._0
{
    partial class MainForm
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
            this.btnSelectImages = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picboxImgPreview = new System.Windows.Forms.PictureBox();
            this.btnPreviewNxt = new System.Windows.Forms.Button();
            this.btnPreviewPrv = new System.Windows.Forms.Button();
            this.lblImageNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHighByte = new System.Windows.Forms.TextBox();
            this.txtLowByte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateGif = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTransparencyIndex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImgPreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.Location = new System.Drawing.Point(14, 188);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Size = new System.Drawing.Size(192, 23);
            this.btnSelectImages.TabIndex = 0;
            this.btnSelectImages.Text = "Import images...";
            this.btnSelectImages.UseVisualStyleBackColor = true;
            this.btnSelectImages.Click += new System.EventHandler(this.btnSelectImages_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(21, 37);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(80, 20);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.Text = "400";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "px";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GIF will be resized, please choose new width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "(aspect ratio will be kept)";
            // 
            // picboxImgPreview
            // 
            this.picboxImgPreview.Location = new System.Drawing.Point(14, 8);
            this.picboxImgPreview.Name = "picboxImgPreview";
            this.picboxImgPreview.Size = new System.Drawing.Size(192, 134);
            this.picboxImgPreview.TabIndex = 5;
            this.picboxImgPreview.TabStop = false;
            // 
            // btnPreviewNxt
            // 
            this.btnPreviewNxt.Location = new System.Drawing.Point(150, 148);
            this.btnPreviewNxt.Name = "btnPreviewNxt";
            this.btnPreviewNxt.Size = new System.Drawing.Size(56, 27);
            this.btnPreviewNxt.TabIndex = 7;
            this.btnPreviewNxt.Text = "Next";
            this.btnPreviewNxt.UseVisualStyleBackColor = true;
            this.btnPreviewNxt.Click += new System.EventHandler(this.btnPreviewNxt_Click);
            // 
            // btnPreviewPrv
            // 
            this.btnPreviewPrv.Location = new System.Drawing.Point(14, 148);
            this.btnPreviewPrv.Name = "btnPreviewPrv";
            this.btnPreviewPrv.Size = new System.Drawing.Size(56, 27);
            this.btnPreviewPrv.TabIndex = 7;
            this.btnPreviewPrv.Text = "Previous";
            this.btnPreviewPrv.UseVisualStyleBackColor = true;
            this.btnPreviewPrv.Click += new System.EventHandler(this.btnPreviewPrv_Click);
            // 
            // lblImageNumber
            // 
            this.lblImageNumber.AutoSize = true;
            this.lblImageNumber.Location = new System.Drawing.Point(92, 155);
            this.lblImageNumber.Name = "lblImageNumber";
            this.lblImageNumber.Size = new System.Drawing.Size(35, 13);
            this.lblImageNumber.TabIndex = 8;
            this.lblImageNumber.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Delay (byte, byte):";
            // 
            // txtHighByte
            // 
            this.txtHighByte.Location = new System.Drawing.Point(21, 100);
            this.txtHighByte.Name = "txtHighByte";
            this.txtHighByte.Size = new System.Drawing.Size(34, 20);
            this.txtHighByte.TabIndex = 1;
            this.txtHighByte.Text = "0";
            this.txtHighByte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLowByte
            // 
            this.txtLowByte.Location = new System.Drawing.Point(67, 100);
            this.txtLowByte.Name = "txtLowByte";
            this.txtLowByte.Size = new System.Drawing.Size(34, 20);
            this.txtLowByte.TabIndex = 1;
            this.txtLowByte.Text = "9";
            this.txtLowByte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = ".";
            // 
            // btnCreateGif
            // 
            this.btnCreateGif.Location = new System.Drawing.Point(191, 198);
            this.btnCreateGif.Name = "btnCreateGif";
            this.btnCreateGif.Size = new System.Drawing.Size(115, 23);
            this.btnCreateGif.TabIndex = 12;
            this.btnCreateGif.Text = "Create GIF";
            this.btnCreateGif.UseVisualStyleBackColor = true;
            this.btnCreateGif.Click += new System.EventHandler(this.btnCreateGIF_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTransparencyIndex);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtWidth);
            this.panel1.Controls.Add(this.btnCreateGif);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLowByte);
            this.panel1.Controls.Add(this.txtHighByte);
            this.panel1.Location = new System.Drawing.Point(243, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 224);
            this.panel1.TabIndex = 13;
            // 
            // txtTransparencyIndex
            // 
            this.txtTransparencyIndex.Location = new System.Drawing.Point(21, 160);
            this.txtTransparencyIndex.Name = "txtTransparencyIndex";
            this.txtTransparencyIndex.Size = new System.Drawing.Size(45, 20);
            this.txtTransparencyIndex.TabIndex = 15;
            this.txtTransparencyIndex.Text = "255";
            this.txtTransparencyIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "0-255 (default = 255)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Set transparency index:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Set the animation speed (frame delay):";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteImage);
            this.panel2.Controls.Add(this.btnPreviewPrv);
            this.panel2.Controls.Add(this.picboxImgPreview);
            this.panel2.Controls.Add(this.btnSelectImages);
            this.panel2.Controls.Add(this.btnPreviewNxt);
            this.panel2.Controls.Add(this.lblImageNumber);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 225);
            this.panel2.TabIndex = 14;
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Location = new System.Drawing.Point(182, 8);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(24, 23);
            this.btnDeleteImage.TabIndex = 9;
            this.btnDeleteImage.Text = "X";
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 245);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "sharpGIFs 3.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxImgPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImages;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picboxImgPreview;
        private System.Windows.Forms.Button btnPreviewNxt;
        private System.Windows.Forms.Button btnPreviewPrv;
        private System.Windows.Forms.Label lblImageNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHighByte;
        private System.Windows.Forms.TextBox txtLowByte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateGif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTransparencyIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteImage;
    }
}

