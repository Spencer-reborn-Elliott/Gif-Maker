using AnimatedGif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gif_Maker
{
    public partial class btnScramble : Form
    {
        readonly Random random = new Random();
        readonly object syncLock = new object();
        string Title = "Gif Creator";
        public btnScramble()
        {
            InitializeComponent();
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            selectPhoto.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
            selectPhoto.FileName = "";
            DialogResult result = selectPhoto.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectPhoto.FileName))
            {
                photo.Image = Image.FromFile(selectPhoto.FileName);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (selectPhoto.FileName.Length > 0)
            {
                List<string> Images = new List<string>();
                for (int i = 0; i < Variations.Value; i++)
                {
                    using (var srcImage = Image.FromFile(selectPhoto.FileName))
                    {
                        using (var newImage = new Bitmap(500, 500))
                        using (var graphics = Graphics.FromImage(newImage))
                        {
                            graphics.SmoothingMode = SmoothingMode.HighQuality;
                            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                            graphics.DrawImage(srcImage, new Rectangle(new Point(0, 0), new Size(500, 500)));

                            if (i == 0)
                            {
                                newImage.Save(@"Image" + i.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                                Images.Add("Image0.png");
                            }
                            else
                            {
                                for (int n = 0; n <= 50; n++)
                                {
                                    graphics.DrawImage(srcImage, new Rectangle(new Point(RandomNumber(0, 5) * 100, RandomNumber(0, 5) * 100), new Size(100, 100)), new Rectangle(new Point(RandomNumber(0, 5) * 100, RandomNumber(0, 5) * 100), new Size(100, 100)), GraphicsUnit.Pixel);
                                }
                                newImage.Save(@"Image" + i.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                                Images.Add("Image" + i.ToString() + ".png");
                            }
                            photo.Image = Image.FromFile("Image" + i.ToString() + ".png");
                        }
                    }
                }
               

                using (var gif = AnimatedGif.AnimatedGif.Create("Animated.gif", (int)delay.Value))
                {
                    for (int i = 0; i < Images.Count; i++)
                    {
                        var img = Image.FromFile(Images[i]);
                        gif.AddFrame(img, delay: -1, quality: GifQuality.Bit8);
                    }
                }

            }
            else
            {
                MessageBox.Show("You need to choose an image first.", Title);
            }
        }


        int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { 
                return random.Next(min, max);
            }
        }

    }
}
