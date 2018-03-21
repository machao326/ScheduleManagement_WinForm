using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TimeTableDemo
{
    public partial class FileInfoDemo : Form
    {
        public FileInfoDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text.ToString())) {
                MessageBox.Show("文件路径不能为空");
            }
            FileInfo myfile = new FileInfo(this.textBox1.Text.ToString());
            if (myfile.Exists)
            {
                textBox2.Text = "文件创建时间：" + myfile.CreationTime.ToString() +
                                ";文件夹:" + myfile.Directory.ToString() +
                                ";文件夹名称：" + myfile.DirectoryName.ToString();
            }
            else
            {
                MessageBox.Show("文件不存在");
            }
        }
    }
}
