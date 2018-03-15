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
    public partial class FormMain : Form
    {
        DBDataContext db = new DBDataContext();
        public FormMain()
        {
            InitializeComponent();
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            BoundType();
            BoundItems();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BoundType()
        {
            var types = db.TimeTableType.ToList();
            types.Insert(0, new TimeTableType { Id = 0, Name = "全部" });
            cboType.DataSource = types;
            cboType.DisplayMember = "Name";
            cboType.ValueMember = "Id";
        }

        private void BoundItems()
        {
            dgvItems.DataSource = db.TimeTable
                                   .Where(item => item.Title.Contains(txtTitle.Text))
                                   .Where(item => cboType.SelectedIndex == 0 ? true : item.TypeId == Convert.ToInt32(cboType.SelectedIndex))
                                   .Where(item => cboAll.Checked ? true : cboIsFinished.Checked == Convert.ToBoolean(item.IsFinished))
                                   .Select(item => new
                                   {
                                       编号 = item.Id,
                                       标题 = item.Title,
                                       分类 = item.TimeTableType.Name,
                                       开始时间 = item.BeginTime,
                                       结束时间 = item.EndTime,

                                       状态 = Convert.ToBoolean(item.IsFinished) ? "已完成" : "未完成"
                                   }).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BoundItems();
        }

        private void 新建项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEdit frm = new FormEdit();
            frm.ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                var primaryKey = Convert.ToInt32(dgvItems.SelectedRows[0].Cells[0].Value);
                var item = db.TimeTable.FirstOrDefault(r => r.Id == primaryKey);
                db.TimeTable.DeleteOnSubmit(item);
                db.SubmitChanges();
                BoundItems();
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                var primaryKey = Convert.ToInt32(dgvItems.SelectedRows[0].Cells[0].Value);
                var item = db.TimeTable.FirstOrDefault(r => r.Id == primaryKey);

                FormEdit frm = new TimeTableDemo.FormEdit { timeTable = item };
                frm.ShowDialog();
            }
        }
    }
}