namespace TimeTableDemo
{
    partial class TreeviewControlDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("IT部");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("系统研发部");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("研发部", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("小组1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("小组2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("生产部", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("根节点", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewNode = new System.Windows.Forms.TextBox();
            this.btnExpandNext = new System.Windows.Forms.Button();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.加入子节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加入兄弟节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(16, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点2";
            treeNode1.Text = "IT部";
            treeNode2.Name = "节点4";
            treeNode2.Text = "系统研发部";
            treeNode3.Name = "节点1";
            treeNode3.Text = "研发部";
            treeNode4.Name = "节点5";
            treeNode4.Text = "小组1";
            treeNode5.Name = "节点6";
            treeNode5.Text = "小组2";
            treeNode6.Name = "节点3";
            treeNode6.Text = "生产部";
            treeNode7.Name = "节点0";
            treeNode7.Text = "根节点";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(383, 416);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "加入节点名称";
            // 
            // txtNewNode
            // 
            this.txtNewNode.Location = new System.Drawing.Point(175, 466);
            this.txtNewNode.Name = "txtNewNode";
            this.txtNewNode.Size = new System.Drawing.Size(224, 28);
            this.txtNewNode.TabIndex = 2;
            // 
            // btnExpandNext
            // 
            this.btnExpandNext.Location = new System.Drawing.Point(24, 517);
            this.btnExpandNext.Name = "btnExpandNext";
            this.btnExpandNext.Size = new System.Drawing.Size(123, 40);
            this.btnExpandNext.TabIndex = 3;
            this.btnExpandNext.Text = "展开下一节";
            this.btnExpandNext.UseVisualStyleBackColor = true;
            this.btnExpandNext.Click += new System.EventHandler(this.btnExpandNext_Click);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Location = new System.Drawing.Point(153, 517);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(118, 40);
            this.btnExpandAll.TabIndex = 4;
            this.btnExpandAll.Text = "全部展开";
            this.btnExpandAll.UseVisualStyleBackColor = true;
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Location = new System.Drawing.Point(277, 517);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(122, 40);
            this.btnCollapse.TabIndex = 5;
            this.btnCollapse.Text = "全部折叠";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加入子节点ToolStripMenuItem,
            this.加入兄弟节点ToolStripMenuItem,
            this.删除节点ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 121);
            // 
            // 加入子节点ToolStripMenuItem
            // 
            this.加入子节点ToolStripMenuItem.Name = "加入子节点ToolStripMenuItem";
            this.加入子节点ToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.加入子节点ToolStripMenuItem.Text = "加入子节点";
            this.加入子节点ToolStripMenuItem.Click += new System.EventHandler(this.加入子节点ToolStripMenuItem_Click);
            // 
            // 加入兄弟节点ToolStripMenuItem
            // 
            this.加入兄弟节点ToolStripMenuItem.Name = "加入兄弟节点ToolStripMenuItem";
            this.加入兄弟节点ToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.加入兄弟节点ToolStripMenuItem.Text = "加入兄弟节点";
            this.加入兄弟节点ToolStripMenuItem.Click += new System.EventHandler(this.加入兄弟节点ToolStripMenuItem_Click);
            // 
            // 删除节点ToolStripMenuItem
            // 
            this.删除节点ToolStripMenuItem.Name = "删除节点ToolStripMenuItem";
            this.删除节点ToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.删除节点ToolStripMenuItem.Text = "删除节点";
            this.删除节点ToolStripMenuItem.Click += new System.EventHandler(this.删除节点ToolStripMenuItem_Click);
            // 
            // TreeviewControlDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 595);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnExpandAll);
            this.Controls.Add(this.btnExpandNext);
            this.Controls.Add(this.txtNewNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeviewControlDemo";
            this.Text = "TreeviewControlDemo";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewNode;
        private System.Windows.Forms.Button btnExpandNext;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 加入子节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加入兄弟节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除节点ToolStripMenuItem;
    }
}