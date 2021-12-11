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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();

            this.Close();//隐藏现在这个窗口

            Form1 f1 = new Form1();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pwd = textBox4.Text;
            string connString = "Data Source=20180402-211622;Initial Catalog=Test;Integrated Security=TRUE";
          //  string connString = "Data Source=222-089;Initial Catalog=Test;Integrated Security=TRUE";
           // string connString = "Data Source=20180402-211622;Initial Catalog=Test;Integrated Security=TRUE";
            SqlConnection connection = new SqlConnection(connString);
            string sql = string.Format("select count(*) from [Table] where username='{0}' and mailbox='{1}'", textBox1.Text, textBox4.Text);

            SqlCommand cmp = new SqlCommand(sql, connection);
            
                   
            try
            {
                connection.Open();  // 打开数据库连接
        

                int i = (int)cmp.ExecuteScalar();

                string name = this.textBox1.Text;
                string youxiang= this.textBox4.Text;
                string pwd1 = this.textBox2.Text;
                string pwd2 = this.textBox3.Text;


                if (name.Equals("") || youxiang.Equals("") || pwd1.Equals("") || pwd2.Equals(""))//用户名或密码为空
                {
                    MessageBox.Show("每一项都不能为空哦~");
                }
                else if (pwd1!=pwd2)

                    MessageBox.Show("两次密码不一致"); 

                //用户名或密码不为空
                else
                {

                    if (i > 0)
                    {
                        string delStr = "update [Table] set pwd='" + textBox3.Text + "'where username='" + textBox1.Text + "'";
                        SqlCommand cmx = new SqlCommand(delStr, connection);
                        int ni = cmx.ExecuteNonQuery();
                        if (ni > 0)
                        {
                            MessageBox.Show("修改成功 正在返回登录");
                        }
                        Form4 fm = new Form4();

                        this.Close();//隐藏现在这个窗口

                        Form1 f1 = new Form1();
                        f1.StartPosition = FormStartPosition.CenterScreen;
                        f1.Show();

                    }
                    else
                    {
                        MessageBox.Show("认证未通过，请检查你用户名与绑定联系方式是否正确 若信息无误请联系系统管理员。");
                        textBox1.Focus();
                    }

                }
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
