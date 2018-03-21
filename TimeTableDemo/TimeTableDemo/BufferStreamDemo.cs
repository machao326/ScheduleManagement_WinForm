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
    public partial class BufferStreamDemo : Form
    {
        public BufferStreamDemo()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "文本文件(*.txt)|*.txt";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                txtSourceTxtFile.Text = openDialog.FileName;
            }
        }

        private void btnBKFile_Click(object sender, EventArgs e)
        {
            Console.Write("{0:MMdd}", Convert.ToDateTime("2013-6-8"));


        }
    }
}
