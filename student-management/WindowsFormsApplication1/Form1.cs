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
    public partial class Form1 : Form
    {

       public int ip = 0;

        public Form1()
        {
            InitializeComponent();
            this.menuStrip1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.jint1; //标题背景为金顶云海
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.jin;   //窗体背景图为金顶云海
            label1.ForeColor = Color.LightYellow;                                               //标签颜色
            textBox1.ForeColor = Color.DimGray;
            textBox2.ForeColor = Color.DimGray;
            menuStrip1.ForeColor = Color.DimGray;
            groupBox1.ForeColor = Color.LightYellow;
            button1.ForeColor = Color.DimGray;
            button2.ForeColor = Color.DimGray;

            button1.BackColor = Color.Transparent;                                             //按钮背景色为透明
            groupBox1.BackColor = Color.Transparent;
            linkLabel1.BackColor =Color.Transparent;
            button2.BackColor = Color.Transparent;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

         
             //string connString = "Data Source=555;Initial Catalog=Test;Integrated Security=TRUE";
            //  string connString = "Data Source=222-089;Initial Catalog=Test;Integrated Security=TRUE";

             //string connString = "Data Source=pc-20181017dlts;Initial Catalog=Test;Integrated Security=TRUE";

            //远程数据库连接
            //string connString = "server=116.255.150.246;User Id=jttc9b_f;password=QWER1234;Database=jttc9b";
            //  MySqlConnection connection = new MySqlConnection(connString);

            string connString = "Data Source=20180402-211622;Initial Catalog=Test;Integrated Security=TRUE";
           SqlConnection connection = new SqlConnection(connString);
    string sql = string.Format("select count(*) from [Table] where username='{0}' and pwd='{1}'", textBox1.Text, textBox2.Text);
    SqlCommand cmd = new SqlCommand(sql, connection);





            try
            {
                connection.Open();  // 打开数据库连接
                MessageBox.Show("连接成功  正在验证登录信息");

               int i = (int)cmd.ExecuteScalar();


                string userid = this.textBox1.Text;
                string password = this.textBox2.Text;




                if (userid.Equals("") || password.Equals(""))//用户名或密码为空
                {
                    MessageBox.Show("用户名或密码不能为空");
                }
                else//用户名或密码不为空
                {

                    if (i>0)
                    {
                        DataClasses1DataContext db = new DataClasses1DataContext();

                        var q = from m in db.Table
                                where m.username == textBox1.Text
                                select m;

                        foreach (var v in q)
                        {
                            //商品编号
                            v.time = DateTime.Now;

                        }

                        db.SubmitChanges();


                        MessageBox.Show("登录成功");
                        Form1 fm = new Form1();

                        this.Hide();//隐藏现在这个窗口

                        Form2 f2 = new Form2(userid);
                        f2.StartPosition = FormStartPosition.CenterScreen;
                        f2.Show();
                        

                        //   f2.Close();
                    }
                    else
                    {
                        MessageBox.Show("认证未通过，请检查你的用户名与密码 若信息无误请联系系统管理员。");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void label2_Click(object sender, EventArgs e)
        {
         

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        
            ip++;
            string password = this.textBox2.Text;
            if (ip%2==0)
                textBox2.PasswordChar=new char();
            else textBox2.PasswordChar = '*';
          

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();

            this.Hide();//隐藏现在这个窗口

            Form4 f4 = new Form4();
            f4.StartPosition = FormStartPosition.CenterScreen;
            f4.Show();
        }

        private void 注册管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDlg.Color;
            }
        }

        private void 改变颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 注册管理员ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
       
        }

        private void 注册激活ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zhuce = "激活正版";
            this.Text = "超市库存后台管理系统" + zhuce;
          
        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();

            this.Hide();//隐藏现在这个窗口

            Form3 f3 = new Form3();
            f3.StartPosition = FormStartPosition.CenterScreen;
            f3.Show();
        }

        private void 联系我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:1614086761@qq.com");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 背景颜色ToolStripMenuItem_Click(object sender, EventArgs e)  //金顶云海
        {
            this.menuStrip1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.jint1;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.jin;
            label1.ForeColor = Color.LightYellow;
            textBox1.ForeColor = Color.DimGray;
            textBox2.ForeColor = Color.DimGray;
            menuStrip1.ForeColor = Color.DimGray;
            groupBox1.ForeColor = Color.LightYellow;
            button1.ForeColor = Color.DimGray;
            button2.ForeColor = Color.DimGray;
            注册激活ToolStripMenuItem.ForeColor = Color.LightSeaGreen;
        }

        private void 自定义字体颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = colorDlg.Color;
                textBox1.ForeColor = colorDlg.Color;
                textBox2.ForeColor = colorDlg.Color;
                menuStrip1.ForeColor = colorDlg.Color;
                groupBox1.ForeColor = colorDlg.Color;
                注册激活ToolStripMenuItem.ForeColor = colorDlg.Color;
            }
        }

        private void ziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bai1;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.hei;
            label1.ForeColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
            menuStrip1.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.WhiteSmoke;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            注册激活ToolStripMenuItem.ForeColor = Color.LightSeaGreen;
        }

        private void 自定义背景色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bai;
            this.menuStrip1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bai1;
            label1.ForeColor = Color.Black;
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
            menuStrip1.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            注册激活ToolStripMenuItem.ForeColor = Color.Black;
        }

        private void 关于管理系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();

            this.Hide();//隐藏现在这个窗口

            Form12 f12 = new Form12();
            f12.StartPosition = FormStartPosition.CenterScreen;
            f12.Show();

        }
    }
}
