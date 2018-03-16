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
    public partial class TreeviewControlDemo : Form
    {
        public TreeviewControlDemo()
        {
            InitializeComponent();
        }

        private void btnExpandNext_Click(object sender, EventArgs e)
        {
            this.treeView1.SelectedNode.Expand();
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            this.treeView1.SelectedNode = treeView1.Nodes[0];
            treeView1.SelectedNode.ExpandAll();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this.treeView1.SelectedNode = treeView1.Nodes[0];
            this.treeView1.SelectedNode.Collapse();
        }

        private void 加入子节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("请选择一个节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtNewNode.Text))
                {
                    //创建一个节点并且初始化
                    TreeNode node = new TreeNode(txtNewNode.Text);
                    treeView1.SelectedNode.Nodes.Add(node);
                    treeView1.SelectedNode = node;
                    treeView1.ExpandAll();
                }
                else
                {
                    MessageBox.Show("请输入要添加的节点名称", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void 加入兄弟节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("没有选中的节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!string.IsNullOrEmpty(txtNewNode.Text))
                {
                    TreeNode node = new TreeNode(txtNewNode.Text);
                    if (treeView1.SelectedNode.Parent == null)
                    {
                        MessageBox.Show("不可以选择根节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        treeView1.SelectedNode.Parent.Nodes.Add(node);
                    }

                    treeView1.ExpandAll();
                }
                else
                {
                    MessageBox.Show("请输入要添加的节点信息", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void 删除节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Nodes.Count > 0)
            {
                MessageBox.Show("请先删除子节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                treeView1.SelectedNode.Remove();
            }
        }
    }
}
