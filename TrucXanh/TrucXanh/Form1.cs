using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Collections;
using System.Globalization;

namespace TrucXanh
{

    public partial class Form1 : Form
    {
        int W = 60, H = 100, Distance = 20, Flag = 0, maxICol = 6, pImage;
        TrucXanh.ListImage list = new TrucXanh.ListImage();
        string hide = "..//..//Res//hide.png";
        PictureBox temp1, temp2;

        public Form1()
        {
            InitializeComponent();



        }
        public Form1(int pImage)
        {
            this.pImage = pImage;
            InitializeComponent();
            list.CreateListImage(pImage);
            CreateSizeFrom(pImage * 2);


        }
        private void CreateSizeFrom(int n)
        {
            int m = n % maxICol, i, j;
            if (m > 0)
            {
                m = n / maxICol + 1;
                n -= n / maxICol * maxICol;
                if (m > 2)
                {
                    for (j = 0; j < m - 1; j++)
                        for (i = 0; i < maxICol; i++)
                            CreatePicture(new Point(i * W + Distance * i, j * H + Distance * j));
                    for (i = 0; i < n; i++)
                        CreatePicture(new Point(i * W + Distance * i, (m - 1) * H + Distance * (m - 1)));
                }
                else
                    for (j = 0; j < m; j++)
                        for (i = 0; i < n; i++)
                            CreatePicture(new Point(i * W + Distance * i, j * H + Distance * j));
                n = maxICol;
            }
            else
            {
                m = n / maxICol;
                n = n / m;
                for (j = 0; j < m; j++)
                    for (i = 0; i < n; i++)
                        CreatePicture(new Point(i * W + Distance * i, j * H + Distance * j));
            }
            this.Width = W * n + Distance * n;
            this.Height = H * m + Distance * m + Distance;

        }
        private void CreatePicture(Point pos)
        {
            string s = list.ranImage(pImage), file = "..//..//Res//";
            PictureBox picture = new PictureBox
            {
                Name = s,

                Size = new Size(W, H),
                Location = pos,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackgroundImage = Image.FromFile(file + s),
                Image = Image.FromFile(hide),


            };

            this.Controls.Add(picture);
            picture.Click += picture_Click;


        }
        private void picture_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (Flag > 1)
            {
                if (temp1.Name == temp2.Name)
                {
                    this.Controls.Remove(getPb(temp1));
                    this.Controls.Remove(getPb(temp2));
                }
                else
                {

                    getPb(temp2).Image = Image.FromFile(hide);
                    getPb(temp1).Image = Image.FromFile(hide);

                }

                Flag = 1;
                pb.Image = null;
                temp1 = pb;
                temp2 = null;

            }
            else if (Flag > 0)
            {

                pb.Image = null;
                Flag++;
                temp2 = pb;
            }
            else
            {

                pb.Image = null;
                Flag++;
                temp1 = pb;
            }

        }
        private PictureBox getPb(PictureBox temp)
        {
            foreach (Control crt in this.Controls)
                if (crt.Location == temp.Location)
                    return (PictureBox)crt;

            return temp;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
