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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
        
            DataClasses1DataContext db = new DataClasses1DataContext();
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
            dataGridView1.Columns[7].Width = 100;


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

            Table_2 user = new Table_2();
           
            user.name = textBox2.Text;
            user.major = textBox1.Text;
            user.@class = textBox3.Text;
            user.year = textBox4.Text;
            user.Teacher = textBox5.Text;
            user.Classroom = textBox6.Text;
            user.Remarks = richTextBox1.Text;  
            user.time = DateTime.Now;
            
            db.Table_2.InsertOnSubmit(user);

            try
            {
                db.SubmitChanges();
                MessageBox.Show("添加成功");

                dataGridView1.DataSource = db.Table_2;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var q = from m in db.Table_2
                    where m.name == textBox2.Text
                    select m;

            foreach (var v in q)
            {

                db.Table_2.DeleteOnSubmit(v);
            }
            try
            {
                db.SubmitChanges();
                MessageBox.Show("删除成功");
                dataGridView1.DataSource = db.Table_2;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
