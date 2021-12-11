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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
          
            DataClasses1DataContext db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Table;
            dataGridView1.Columns[0].HeaderText = "用户名-学号";
            dataGridView1.Columns[1].HeaderText = "密码";
            dataGridView1.Columns[2].HeaderText = "邮箱";
            dataGridView1.Columns[3].HeaderText = "属性";
            dataGridView1.Columns[4].HeaderText = "最近登录时间";
      
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;

            comboBox1.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (button2.Text.Equals("添加"))
            {

                DataClasses1DataContext db = new DataClasses1DataContext();

                Table user = new Table();
                user.username = textBox2.Text;                //用户名
                user.pwd = textBox4.Text;                     //密码
                user.mailbox = textBox5.Text;                //邮箱
                user.type = comboBox1.Text;                   //职位
                user.time = DateTime.Now;
                db.Table.InsertOnSubmit(user);

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("添加成功");

                    dataGridView1.DataSource = db.Table;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else {


                DataClasses1DataContext db = new DataClasses1DataContext();

                var q = from m in db.Table
                        where m.username == textBox2.Text
                        select m;

                foreach (var v in q)
                {

                    v.username= textBox2.Text;                      
                    v.pwd = textBox4.Text;
                    v.mailbox = textBox5.Text;
                    v.type = comboBox1.Text;               

                }
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("修改成功");
                    dataGridView1.DataSource = db.Table;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }      
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int ip = 0;
            DataClasses1DataContext db = new DataClasses1DataContext();

            var q = from m in db.Table
                    where m.username == textBox2.Text
                    select m;

            foreach (var v in q)
            {
                ip = 1;
                textBox2.Text = v.username;                     
                textBox4.Text = v.pwd;                    
                textBox5.Text=v.mailbox;
                comboBox1.Text = v.type;
                button2.Text = "修改";
            }
            if (ip != 1)
            {
               
                textBox4.Text = "";                 
                textBox5.Text = "";                       
                comboBox1.SelectedIndex = 0;                  
                button2.Text = "添加";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var q = from m in db.Table
                    where m.username == textBox2.Text
                    select m;

            foreach (var v in q)
            {

                db.Table.DeleteOnSubmit(v);
            }
            try
            {
                db.SubmitChanges();
                MessageBox.Show("删除成功");
                dataGridView1.DataSource = db.Table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
