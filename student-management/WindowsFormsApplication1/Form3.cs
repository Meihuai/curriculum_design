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

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.SelectedIndex=1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            string username = textBox1.Text;
            string pwd1 = textBox2.Text;
            string mailbox = textBox4.Text;
            string type = comboBox1.Text;
            string pwd2 = textBox3.Text;
            string pinzhen = textBox5.Text;
            DateTime time = DateTime.Now;
            if (type.Equals("系统管理员") || type.Equals("教师"))
            { this.textBox5.Visible = true;
                this.label8.Visible = true;
            }
            else
            {
                this.textBox5.Visible = false;
                this.label8.Visible = false;
            }

            if (username.Equals("") || pwd1.Equals("") || mailbox.Equals("") || type.Equals("") || pwd2.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("每一项都不能为空哦~");
            }
            else if (pwd1 != pwd2)

                MessageBox.Show("两次密码不一致");

            else if ((type.Equals("教师")||type.Equals("系统管理员"))&&pinzhen != "美华")

            {
                    MessageBox.Show("对不起 系统管理员与教师需先联系管理员进行申请 如有需要请联系系统管理员");
            }
            else
            {

                //string connString = "Data Source=222-089;Initial Catalog=Test;Integrated Security=TRUE";
                string connString = "Data Source=20180402-211622;Initial Catalog=Test;Integrated Security=TRUE";

                SqlConnection connection = new SqlConnection(connString);
                string sql = "insert into [Table] values(@username,@pwd,@mailbox,@type,@time)";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@username", username);
                cmd.Parameters.Add("@pwd", pwd1);
                cmd.Parameters.Add("@mailbox", mailbox);
                cmd.Parameters.Add("@type", type);
                cmd.Parameters.Add("@time", time);
                try
                {
                    connection.Open();  // 打开数据库连接

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("     恭喜你 注册成功!\n  请牢记你的用户名  :'" + textBox1.Text + "'密码:'" + textBox2.Text + "'");

                    else MessageBox.Show("注册失败  请检查你的网络环境或联系系统管理员！");

                }


                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();

            this.Close();//隐藏现在这个窗口

            Form1 f1 = new Form1();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)

        {
        
            System.Diagnostics.Process.Start("mailto:1614086761@qq.com");
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            

            Form1 f1 = new Form1();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
