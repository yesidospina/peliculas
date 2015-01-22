using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliculasWinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos JPEG(*.jpg) |*.jpg";
            open.InitialDirectory = "D:\\DESARROLLO";

            if(open.ShowDialog() == DialogResult.OK)
            {
                string dir = open.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                Bitmap picture = new Bitmap(dir);
                pictureBox1.Image = (Image)picture;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
             open = new OpenFileDialog();
            open.FileName
        }
    }
}
