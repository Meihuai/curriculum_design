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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
       
        }

        private void Form9_Load(object sender, EventArgs e)
        {
        
            DataClasses1DataContext db = new DataClasses1DataContext();
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
            dataGridView1.Columns[4].Width = 150;


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

            Table_4 user = new Table_4();
           
            user.id = int.Parse(textBox2.Text);
            user.username = textBox5.Text;
            user.sex = comboBox1.Text;
            user.age = int.Parse(textBox3.Text);
            user.Education = comboBox2.Text;
       

            db.Table_4.InsertOnSubmit(user);

            try
            {
                db.SubmitChanges();
                MessageBox.Show("添加成功");

                dataGridView1.DataSource = db.Table_4;
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

            var q = from m in db.Table_4
                    where m.id == int.Parse(textBox2.Text)
                    select m;

            foreach (var v in q)
            {
                db.Table_4.DeleteOnSubmit(v);
            }
            try
            {
                db.SubmitChanges();
                MessageBox.Show("删除成功");
                dataGridView1.DataSource = db.Table_4;
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
    }
}
