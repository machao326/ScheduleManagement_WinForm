namespace TimeTableDemo
{
    partial class CheckListControlDemo
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
            this.leftCLB = new System.Windows.Forms.CheckedListBox();
            this.rightCLB = new System.Windows.Forms.CheckedListBox();
            this.btnAllToRight = new System.Windows.Forms.Button();
            this.btnAllToLeft = new System.Windows.Forms.Button();
            this.btnSingleToRight = new System.Windows.Forms.Button();
            this.btnSingleToLeft = new System.Windows.Forms.Button();
            this.resultCLB = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // leftCLB
            // 
            this.leftCLB.CheckOnClick = true;
            this.leftCLB.FormattingEnabled = true;
            this.leftCLB.Items.AddRange(new object[] {
            "星期一",
            "星期二",
            "星期三",
            "星期四",
            "星期五",
            "星期六",
            "星期天"});
            this.leftCLB.Location = new System.Drawing.Point(25, 31);
            this.leftCLB.Name = "leftCLB";
            this.leftCLB.Size = new System.Drawing.Size(191, 257);
            this.leftCLB.TabIndex = 0;
            // 
            // rightCLB
            // 
            this.rightCLB.CheckOnClick = true;
            this.rightCLB.FormattingEnabled = true;
            this.rightCLB.Location = new System.Drawing.Point(423, 31);
            this.rightCLB.Name = "rightCLB";
            this.rightCLB.Size = new System.Drawing.Size(191, 257);
            this.rightCLB.TabIndex = 1;
            // 
            // btnAllToRight
            // 
            this.btnAllToRight.Location = new System.Drawing.Point(262, 31);
            this.btnAllToRight.Name = "btnAllToRight";
            this.btnAllToRight.Size = new System.Drawing.Size(101, 34);
            this.btnAllToRight.TabIndex = 2;
            this.btnAllToRight.Text = ">>";
            this.btnAllToRight.UseVisualStyleBackColor = true;
            this.btnAllToRight.Click += new System.EventHandler(this.btnAllToRight_Click);
            // 
            // btnAllToLeft
            // 
            this.btnAllToLeft.Location = new System.Drawing.Point(262, 180);
            this.btnAllToLeft.Name = "btnAllToLeft";
            this.btnAllToLeft.Size = new System.Drawing.Size(101, 34);
            this.btnAllToLeft.TabIndex = 3;
            this.btnAllToLeft.Text = "<<";
            this.btnAllToLeft.UseVisualStyleBackColor = true;
            this.btnAllToLeft.Click += new System.EventHandler(this.btnAllToLeft_Click);
            // 
            // btnSingleToRight
            // 
            this.btnSingleToRight.Location = new System.Drawing.Point(262, 88);
            this.btnSingleToRight.Name = "btnSingleToRight";
            this.btnSingleToRight.Size = new System.Drawing.Size(101, 34);
            this.btnSingleToRight.TabIndex = 4;
            this.btnSingleToRight.Text = "->";
            this.btnSingleToRight.UseVisualStyleBackColor = true;
            this.btnSingleToRight.Click += new System.EventHandler(this.btnSingleToRight_Click);
            // 
            // btnSingleToLeft
            // 
            this.btnSingleToLeft.Location = new System.Drawing.Point(262, 236);
            this.btnSingleToLeft.Name = "btnSingleToLeft";
            this.btnSingleToLeft.Size = new System.Drawing.Size(101, 34);
            this.btnSingleToLeft.TabIndex = 5;
            this.btnSingleToLeft.Text = "<-";
            this.btnSingleToLeft.UseVisualStyleBackColor = true;
            this.btnSingleToLeft.Click += new System.EventHandler(this.btnSingleToLeft_Click);
            // 
            // resultCLB
            // 
            this.resultCLB.FormattingEnabled = true;
            this.resultCLB.Location = new System.Drawing.Point(35, 332);
            this.resultCLB.Name = "resultCLB";
            this.resultCLB.Size = new System.Drawing.Size(579, 257);
            this.resultCLB.TabIndex = 6;
            // 
            // CheckListControlDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 672);
            this.Controls.Add(this.resultCLB);
            this.Controls.Add(this.btnSingleToLeft);
            this.Controls.Add(this.btnSingleToRight);
            this.Controls.Add(this.btnAllToLeft);
            this.Controls.Add(this.btnAllToRight);
            this.Controls.Add(this.rightCLB);
            this.Controls.Add(this.leftCLB);
            this.Name = "CheckListControlDemo";
            this.Text = "CheckListControlDemo";
            this.Load += new System.EventHandler(this.CheckListControlDemo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox leftCLB;
        private System.Windows.Forms.CheckedListBox rightCLB;
        private System.Windows.Forms.Button btnAllToRight;
        private System.Windows.Forms.Button btnAllToLeft;
        private System.Windows.Forms.Button btnSingleToRight;
        private System.Windows.Forms.Button btnSingleToLeft;
        private System.Windows.Forms.CheckedListBox resultCLB;
    }
}