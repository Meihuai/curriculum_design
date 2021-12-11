using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;  

namespace WindowsFormsApplication1
{
    public partial class Form10 : Form
    {
        string ter;
        string p;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            var w = (from name1 in db.Table_5 select name1).ToList();
            foreach (var v in w)
                comboBox3.Items.Add(v.name1);
       
            comboBox3.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            dataGridView1.DataSource = db.Table_6;
            dataGridView1.Columns[0].HeaderText = "课程名称";
            dataGridView1.Columns[1].HeaderText = "授课地点";
            dataGridView1.Columns[2].HeaderText = "授课时间";
            dataGridView1.Columns[3].HeaderText = "任课教师";
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 180;

     

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
           
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

        

          

            Table_6 user = new Table_6();

            user.kcheng = comboBox3.Text;
            user.didian = textBox1.Text;
            user.Teacher = ter;
            user.time = comboBox2.Text;
      
            db.Table_6.InsertOnSubmit(user);

            try
            {
                db.SubmitChanges();
                MessageBox.Show("添加授课信息成功");

                dataGridView1.DataSource = db.Table_6;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_BackColorChanged(object sender, EventArgs e)
        {
      

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ip = 0;
            DataClasses1DataContext db = new DataClasses1DataContext();

            var q = from m in db.Table_5
                    where m.name1 == comboBox3.Text
                    select m;

            foreach (var v in q)
            {
                ip = 1;
                label4.Text = "课程编号 : " + v.id;
                label5.Text = "班级名称 : " + v.name;
                label6.Text = "课程名称 : " + v.name1;
                label7.Text = "任课教师 : " + v.username;
                ter = v.username;
                label8.Text = "开课时间 : " + v.time;

            }
            if (ip != 1)
            {

                label4.Text = "课程编号";
                label5.Text = "班级名称";
                label6.Text = "课程名称";
                label7.Text = "任课教师";
                label8.Text = "开课时间";

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
