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
    public partial class TabControlDemo : Form
    {
        public TabControlDemo()
        {
            InitializeComponent();
        }

        private void tab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label1.Text = "当前为第" + (this.tab1.SelectedIndex+1)+ "个页面";
        }
    }
}
