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
    public partial class CheckListControlDemo : Form
    {
        public CheckListControlDemo()
        {
            InitializeComponent();
        }

        private void CheckListControlDemo_Load(object sender, EventArgs e)
        {

        }

        private void btnAllToRight_Click(object sender, EventArgs e)
        {
            foreach (var item in leftCLB.Items)
            {
                rightCLB.Items.Add(item);
            }
            leftCLB.Items.Clear();
            resultCLB.Items.Add("全部移至右侧");
        }

        private void btnSingleToRight_Click(object sender, EventArgs e)
        {
            foreach (var item in leftCLB.CheckedItems)
            {
                rightCLB.Items.Add(item);
            }
            for (var i =leftCLB.Items.Count-1;i>=0; i--)
            {
                if (leftCLB.CheckedItems.Contains(leftCLB.Items[i]))
                {
                    resultCLB.Items.Add(leftCLB.Items[i].ToString() + "被移至右侧");
                    
                    leftCLB.Items.Remove(leftCLB.Items[i]);
                }
            }
        }

        private void btnAllToLeft_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < rightCLB.Items.Count; i++)
            {
                leftCLB.Items.Add(rightCLB.Items[i]);
            }

            rightCLB.Items.Clear();
            resultCLB.Items.Add("全部移至左侧");
        }

        private void btnSingleToLeft_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < rightCLB.CheckedItems.Count; i++)
            {
                leftCLB.Items.Add(rightCLB.CheckedItems[i]);
            }
            for (var i = rightCLB.Items.Count-1; i >= 0; i--)
            {
                if (rightCLB.CheckedItems.Contains(rightCLB.Items[i]))
                {
                    rightCLB.Items.Remove(rightCLB.CheckedItems[i]);
                    resultCLB.Items.Add(rightCLB.CheckedItems[i].ToString() + "被移至左侧");
                }
            }
        }
    }
}
