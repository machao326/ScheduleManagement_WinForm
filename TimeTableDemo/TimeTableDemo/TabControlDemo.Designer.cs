namespace TimeTableDemo
{
    partial class TabControlDemo
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabNew = new System.Windows.Forms.TabPage();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabNew);
            this.tab1.Controls.Add(this.tabEdit);
            this.tab1.Location = new System.Drawing.Point(12, 3);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.ShowToolTips = true;
            this.tab1.Size = new System.Drawing.Size(309, 246);
            this.tab1.TabIndex = 0;
            this.tab1.SelectedIndexChanged += new System.EventHandler(this.tab1_SelectedIndexChanged);
            // 
            // tabNew
            // 
            this.tabNew.Location = new System.Drawing.Point(4, 28);
            this.tabNew.Name = "tabNew";
            this.tabNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabNew.Size = new System.Drawing.Size(301, 214);
            this.tabNew.TabIndex = 0;
            this.tabNew.Text = "新建";
            this.tabNew.ToolTipText = "新建啊 啊啊啊 啊啊";
            this.tabNew.UseVisualStyleBackColor = true;
            // 
            // tabEdit
            // 
            this.tabEdit.Location = new System.Drawing.Point(4, 28);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(301, 214);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "编辑";
            this.tabEdit.ToolTipText = "编辑啊啊啊 啊啊啊啊 啊";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // TabControlDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab1);
            this.Name = "TabControlDemo";
            this.Text = "TabControlDemo";
            this.tab1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabNew;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Label label1;
    }
}