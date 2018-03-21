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
    public partial class FileHandleDemo : Form
    {
        public FileHandleDemo()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFilePath.Text))
            {
                MessageBox.Show("文件路径不能为空");
                return;
            }
            if (!File.Exists(this.txtFilePath.Text.ToString()))
            {
                MessageBox.Show("文件不存在");
                return;
            }
            //using (StreamWriter sw = File.CreateText(this.txtFilePath.Text.ToString())) {
            //    sw.WriteLine("hello");
            //    sw.WriteLine("and");
            //    sw.WriteLine("welcome");
            //}
            var result = string.Empty;
            using (StreamReader sr = new StreamReader(this.txtFilePath.Text.ToString(), System.Text.Encoding.Default))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    result += s;
                }
            }
            this.txtFileInfo.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("需要拷贝的文件路径不能为空");
            }
            if (File.Exists(this.textBox1.Text.ToString()))
            {
                File.Delete(this.textBox1.Text.ToString());
            }
            File.Copy(this.txtFilePath.Text.ToString(), this.textBox1.Text.ToString());
        }
    }
}
