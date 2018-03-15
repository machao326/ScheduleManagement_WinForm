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
    public partial class FormEdit : Form
    {
        DBDataContext db = new DBDataContext();

        public TimeTable timeTable { get; set; }
       
        public FormEdit()
        {
            InitializeComponent();

            Load += FormEdit_Load;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            BoundType();

            BoundTimeTable();
        }

        private void BoundTimeTable() {
            try
            {
                if (timeTable != null)
                {
                    this.txtTitle.Text = timeTable.Title;
                    this.txtAddress.Text = timeTable.Address;
                    this.txtContent.Text = timeTable.MainContent;
                    this.cboType.SelectedValue = timeTable.TypeId == null ? 0 : timeTable.TypeId.Value;
                    this.dtBeginTime.Value = timeTable.BeginTime.HasValue ? timeTable.BeginTime.Value : DateTime.Now;
                    this.dtEndTime.Value = timeTable.EndTime.HasValue ? timeTable.EndTime.Value : DateTime.Now;

                    cbFinished.Checked = Convert.ToBoolean(timeTable.IsFinished);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BoundType() {
            cboType.DataSource = db.TimeTableType.ToList();
            cboType.DisplayMember = "Name";
            cboType.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (timeTable != null)
            {
                try
                {
                    var item = db.TimeTable.FirstOrDefault(r => r.Id == timeTable.Id);
                    item.Title = this.txtTitle.Text;
                    item.Address = this.txtAddress.Text;
                    item.BeginTime = this.dtBeginTime.Value;
                    item.EndTime = this.dtEndTime.Value;
                    item.TypeId = Convert.ToInt32(this.cboType.SelectedValue);
                    item.IsFinished = this.cbFinished.Checked;
                    item.MainContent = this.txtContent.Text;
                    db.SubmitChanges();
                    MessageBox.Show("保存成功");
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("保存数据失败，错误信息:" + exception.Message);
                }
            }
            else
            {
                db.TimeTable.InsertOnSubmit(new TimeTable
                {
                    Title = this.txtTitle.Text,
                    Address = this.txtAddress.Text,
                    BeginTime = this.dtBeginTime.Value,
                    EndTime = this.dtEndTime.Value,
                    TypeId = Convert.ToInt32(this.cboType.SelectedValue),
                    MainContent = this.txtContent.Text,
                    IsFinished = this.cbFinished.Checked
                    
                });
                db.SubmitChanges();
                MessageBox.Show("新增成功");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var fasdfas = "fdasdfa";
            this.Close();
        }
    }
}
