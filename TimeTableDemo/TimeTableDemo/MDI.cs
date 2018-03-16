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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            //判断是否有重复窗口
            foreach (Form form in this.MdiChildren) {
                if (form.Name == "Form2") {
                    form.Visible = true;
                    form.Activate();
                    return;
                }
            }
            Form2 mdchild = new Form2();
            mdchild.MdiParent = this;
            mdchild.Show();
            //这个窗口和其他窗口的显示方式为层叠
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            //判断是否有重复窗口
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "Form3")
                {
                    form.Visible = true;
                    form.Activate();
                    return;
                }
            }
            Form3 mdchild = new Form3();
            mdchild.MdiParent = this;
            mdchild.Show();
            //这个窗口和其他窗口的显示方式为垂直平铺
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
