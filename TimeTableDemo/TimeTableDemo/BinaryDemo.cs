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
    public partial class BinaryDemo : Form
    {
        public BinaryDemo()
        {
            InitializeComponent();
        }

        private void openPic_Click(object sender, EventArgs e)
        {
           
        }

        public byte[] getFileBytes(string fileName) {
            if (fileName == "") {
                return null;
            }
            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
             
                byte[] fileBytes = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();
                return fileBytes;
            }
            catch (Exception ex) {
                return null;
            }
        }

        public bool WriteFileBytes(string targetFileName, byte[] fileBytes) {
            bool k = true;
            if (targetFileName != "" && fileBytes.Length > 0)
            {
                try
                {
                    FileStream fileStream = new FileStream(targetFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryWriter binaryWrite = new BinaryWriter(fileStream);
                    binaryWrite.Write(fileBytes);
                    binaryWrite.Flush();
                    binaryWrite.Close();
                    fileStream.Close();

                }
                catch (Exception ex)
                {
                    k = false;
                }
            }
            else {
                k = false;
            }
            return k;
        }

        private void copyPic_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1 == null)
                {
                    MessageBox.Show("禁止图片为空");
                }
                else
                {
                    saveFileDialog1.Filter = "jpg类型图片(*.jpg)|*.jpg";
                    DialogResult result = saveFileDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MemoryStream ms = new MemoryStream();
                        Bitmap bm = new Bitmap(pictureBox1.Image);
                        bm.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] bytes = ms.ToArray();
                        WriteFileBytes(saveFileDialog1.FileName, bytes);
                        MessageBox.Show("另存图片成功", "提示");
                        ms.Dispose();
                        ms.Close();
                        bm.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取图片出错：" + ex.ToString());
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "jpg类型图片(.jpg)|*.jpg|BMP类型图片(.bmp)|*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] picBinary = getFileBytes(openFileDialog.FileName);
                    MemoryStream mempicStream = new MemoryStream(picBinary);
                    pictureBox1.Image = Image.FromStream(mempicStream);
                    mempicStream.Dispose();
                    mempicStream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取图片出错,错误信息:" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取D盘下aaa文件夹下面的所有文件     
            string[] path = Directory.GetFiles(@"D:\新建文件夹");
            foreach (string str in path)
            {
                FileInfo file = new FileInfo(str);
                //截取文件名 如 asdf.txt ->asdf                
                //string f = file.Name.Substring(0, file.Name.LastIndexOf("."));
                //替换指定文件名 新文件地址      file.Extension指文件的后缀名         
                string p = @"D:\aaa\" +(file.Name.ToString()+".gif");               
                //将指定文件移动到新的位置,并重新指定文件名                
                file.MoveTo(p);
            }

        }
    }
}
