using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form8 : Form
    {
        string qx,na;
        public Form8(string name,string quanxian)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            qx = quanxian;
            na = name;

        }
        
        private void Form8_Load(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            switch (comboBox1.Text)
            {
                case "学生信息":
                    {
                        if (qx == "学生")
                        {
                            var q = from m in db.Table_1
                                    where m.Cid == na
                                    select m;
                            dataGridView1.DataSource = q; 
                        }
                        else dataGridView1.DataSource = db.Table_1; 
                        dataGridView1.Columns[0].HeaderText = "学号";
                        dataGridView1.Columns[1].HeaderText = "姓名";
                        dataGridView1.Columns[2].HeaderText = "性别";
                        dataGridView1.Columns[3].HeaderText = "民族";
                        dataGridView1.Columns[4].HeaderText = "班级";
                        dataGridView1.Columns[5].HeaderText = "电话";
                        dataGridView1.Columns[6].HeaderText = "备注";
                        dataGridView1.Columns[7].HeaderText = "图片";
                        dataGridView1.Columns[0].Width = 70;
                        dataGridView1.Columns[1].Width = 100;
                        dataGridView1.Columns[2].Width = 100;
                        dataGridView1.Columns[3].Width = 100;
                        dataGridView1.Columns[4].Width = 100;
                        dataGridView1.Columns[5].Width = 120;
                        dataGridView1.Columns[6].Width = 70;
                        dataGridView1.Columns[7].Width = 70; break;
                    }
                case "班级信息":
                    {
                        dataGridView1.DataSource = db.Table_2; 
                        dataGridView1.Columns[0].HeaderText = "班级名称";
                        dataGridView1.Columns[2].HeaderText = "专业名称";
                        dataGridView1.Columns[3].HeaderText = "班级";
                        dataGridView1.Columns[4].HeaderText = "年制";
                        dataGridView1.Columns[5].HeaderText = "教师";
                        dataGridView1.Columns[6].HeaderText = "教室";
                        dataGridView1.Columns[7].HeaderText = "备注";
                        dataGridView1.Columns[1].HeaderText = "添加时间";

                        dataGridView1.Columns[0].Width = 100;
                        dataGridView1.Columns[1].Width = 100;
                        dataGridView1.Columns[2].Width = 100;
                        dataGridView1.Columns[3].Width = 100;
                        dataGridView1.Columns[4].Width = 100;
                        dataGridView1.Columns[5].Width = 100;
                        dataGridView1.Columns[6].Width = 100;
                        dataGridView1.Columns[7].Width = 80; break;
                    }
                case "成绩信息":
                    {
                        if (qx == "学生")
                        {
                            var q = from m in db.Table_3
                                    where m.ID == na
                                    select m;
                            dataGridView1.DataSource = q;
                        }
                        else dataGridView1.DataSource = db.Table_3; 

              
                        dataGridView1.Columns[0].HeaderText = "学号";
                        dataGridView1.Columns[1].HeaderText = "学期";
                        dataGridView1.Columns[2].HeaderText = "成绩";
                        dataGridView1.Columns[3].HeaderText = "课程";
                        dataGridView1.Columns[4].HeaderText = "记录时间";

                        dataGridView1.Columns[0].Width = 140;
                        dataGridView1.Columns[1].Width = 140;
                        dataGridView1.Columns[2].Width = 180;
                        dataGridView1.Columns[3].Width = 150;
                        dataGridView1.Columns[4].Width = 180; break;
                    }
                case "教师信息":
                    {
                        dataGridView1.DataSource = db.Table_4; 
                        dataGridView1.Columns[0].HeaderText = "教师编号";
                        dataGridView1.Columns[1].HeaderText = "教师姓名";
                        dataGridView1.Columns[2].HeaderText = "教师学历";
                        dataGridView1.Columns[3].HeaderText = "年龄";
                        dataGridView1.Columns[4].HeaderText = "性别";

                        dataGridView1.Columns[0].Width = 150;
                        dataGridView1.Columns[1].Width = 150;
                        dataGridView1.Columns[2].Width = 150;
                        dataGridView1.Columns[3].Width = 150;
                        dataGridView1.Columns[4].Width = 150; break;
                    }
                case "课程信息":
                    {
                        dataGridView1.DataSource = db.Table_5; 
                        dataGridView1.Columns[0].HeaderText = "课程编号";
                        dataGridView1.Columns[1].HeaderText = "班级名称";
                        dataGridView1.Columns[2].HeaderText = "课程名称";
                        dataGridView1.Columns[3].HeaderText = "开课学期";
                        dataGridView1.Columns[4].HeaderText = "教师名称";

                        dataGridView1.Columns[0].Width = 150;
                        dataGridView1.Columns[1].Width = 120;
                        dataGridView1.Columns[2].Width = 200;
                        dataGridView1.Columns[3].Width = 150;
                        dataGridView1.Columns[4].Width = 130;
                        break;
                    }
                case "授课信息":
                    {
                        dataGridView1.DataSource = db.Table_6;
                        dataGridView1.Columns[0].HeaderText = "课程名称";
                        dataGridView1.Columns[1].HeaderText = "授课地点";
                        dataGridView1.Columns[2].HeaderText = "授课时间";
                        dataGridView1.Columns[3].HeaderText = "任课教师";
                        dataGridView1.Columns[0].Width = 180;
                        dataGridView1.Columns[1].Width = 180;
                        dataGridView1.Columns[2].Width = 180;
                        dataGridView1.Columns[3].Width = 180; break;
                    }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
