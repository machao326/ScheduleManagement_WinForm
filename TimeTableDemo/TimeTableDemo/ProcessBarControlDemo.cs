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
    public partial class ProcessBarControlDemo : Form
    {
        public ProcessBarControlDemo()
        {
            InitializeComponent();
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (var i = 1; i < 10000; i++) {
                progressBar1.Value = i ;
            }
        }

        private void init() {
            this.progressBar1.Minimum = 0;
            this.progressBar1.Visible = true;
            this.progressBar1.Maximum = 10000;
            this.progressBar1.BackColor = Color.Red;
        }
    }
}
