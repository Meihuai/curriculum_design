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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
       
        }

        private void Form9_Load(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
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




            var w = (from name in db.Table_2 select name).ToList();
            foreach (var v in w)
                comboBox1.Items.Add(v.name);
            comboBox1.SelectedIndex = 1;


            var x = (from username in db.Table_4 select username).ToList();
            foreach (var v in x)
                comboBox3.Items.Add(v.username);
            comboBox3.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

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

            Table_5 user = new Table_5();
           
            user.id = int.Parse(textBox2.Text);
            user.name = comboBox1.Text;
            user.name1 = textBox3.Text;
            user.time = comboBox2.Text;
            user.username = comboBox3.Text;
            db.Table_5.InsertOnSubmit(user);

            try
            {
                db.SubmitChanges();
                MessageBox.Show("添加成功");

                dataGridView1.DataSource = db.Table_5;
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

            var q = from m in db.Table_5
                    where m.name == textBox2.Text
                    select m;

            foreach (var v in q)
            {
                db.Table_5.DeleteOnSubmit(v);
            }
            try
            {
                db.SubmitChanges();
                MessageBox.Show("删除成功");
                dataGridView1.DataSource = db.Table_5;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
