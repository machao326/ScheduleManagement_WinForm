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
    public partial class StatusStripControlDemo : Form
    {
        public StatusStripControlDemo()
        {
            InitializeComponent();

            Load += StatusStripControlDemo_Load;
        }

        private void StatusStripControlDemo_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "现在的日期是:" + DateTime.Now.ToShortDateString() +
                 ";现在的时间是：" + DateTime.Now.ToShortTimeString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "字数信息是：" + richTextBox1.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatusStrip sb = new StatusStrip();
            ToolStripLabel ts1 = new ToolStripLabel();
            ts1.Text = "新增加的工具条";
            ToolStripItem[] tsi = new ToolStripItem[1];
            tsi[0] = ts1;
            sb.Items.AddRange(tsi);
            this.Controls.Add(sb);
        }
    }
}
