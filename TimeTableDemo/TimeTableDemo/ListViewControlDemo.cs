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
    public partial class ListViewControlDemo : Form
    {
        public ListViewControlDemo()
        {
            InitializeComponent();

            listView1.View = View.Details;

            Load += ListViewControlDemo_Load;

            InitListView2();
        }

        private void ListViewControlDemo_Load(object sender, EventArgs e)
        {
            ColumnHeader header = new ColumnHeader();
            header.Text = "姓名";
            header.TextAlign = HorizontalAlignment.Center;
            header.Width = 100;
            listView1.Columns.Add(header);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Columns.Add("年龄", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("班级", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("性别", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("职业", 100, HorizontalAlignment.Center);
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Columns.Remove(listView1.Columns[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();

            listView1.Items.Add("row1", "张三", 0);
            listView1.Items["row1"].SubItems.Add("26");
            listView1.Items["row1"].SubItems.Add("98001");
            listView1.Items["row1"].SubItems.Add("男");
            listView1.Items["row1"].SubItems.Add("学生");

            listView1.EndUpdate();

            this.listView1.GridLines = true;
            this.listView1.View = View.Details;
            this.listView1.LabelEdit = true;
            this.listView1.Scrollable = true;
            this.listView1.HeaderStyle = ColumnHeaderStyle.Clickable;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.listView1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listView1.SelectedItems) {
                MessageBox.Show(item.Text);
            }
        }


        public void InitListView2()
        {
            var dbData = DB();
            //防止每次添加项目时候回重新绘制ListView
            listView2.BeginUpdate();
            foreach (var item in dbData)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = item.Name;
                lv.SubItems.Add(item.Age);
                lv.SubItems.Add(item.Classes);
                lv.SubItems.Add(item.Sex);
                lv.SubItems.Add(item.Career);
                listView2.Items.Add(lv);
            }
            listView2.EndUpdate();
        }

        private List<PersonInfo> DB() {
            List<PersonInfo> reusult = new List<TimeTableDemo.PersonInfo>();
            PersonInfo person1 = new TimeTableDemo.PersonInfo();
            person1.Name = "比尔";
            person1.Age = "89";
            person1.Classes = "One";
            person1.Sex = "男";
            person1.Career="程序员";
            PersonInfo person2 = new TimeTableDemo.PersonInfo();
            person2.Name = "马斯克";
            person2.Age = "40";
            person2.Classes = "Tow";
            person2.Sex = "男";
            person2.Career = "程序员";
            reusult.Add(person1);
            reusult.Add(person2);
            return reusult;
        }
    }
  
    public class PersonInfo
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Classes { get; set; }
        public string Sex { get; set; }
        public string Career { get; set; }
    }
}
