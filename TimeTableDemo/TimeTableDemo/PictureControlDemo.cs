using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableDemo
{
    public partial class PictureControlDemo : Form
    {
        public PictureControlDemo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                showPic();
            }
            else {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        /// <summary>
        /// 显示图片
        /// </summary>
        private void showPic()
        {
            pictureBox1.Image = Image.FromFile(System.Environment.GetFolderPath(
                System.Environment.SpecialFolder.Personal) + @"\Picture.jpg");
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }
    }
}
