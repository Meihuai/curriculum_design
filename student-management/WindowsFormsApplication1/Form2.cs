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
    public partial class Form2 : Form
    {
        string name;
        string quanxian; 
        public Form2(string userid)
        {
       

          
            InitializeComponent();
            name = userid;
            DataClasses1DataContext db = new DataClasses1DataContext();

            var q = from m in db.Table
                    where m.username == name
                    select m;
               foreach (var v in q)
            {
                quanxian = v.type; 
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        // Form1 fm = new Form1();
        //https://bbs.csdn.net/topics/392086659
          //  fm.Close();//隐藏现在这个窗口

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void 安全退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quanxian == "系统管理员")
            {
                Form10 f10 = new Form10();
                f10.MdiParent = this;
                f10.WindowState = FormWindowState.Maximized;
                f10.Show();

            }
            else if (quanxian == "学生")
            {
                MessageBox.Show("没有权限访问");
            }

            else if (quanxian == "教师")
            {

                Form10 f10 = new Form10();
                f10.MdiParent = this;
                f10.WindowState = FormWindowState.Maximized;
                f10.Show();

            }
            else MessageBox.Show("未知的权限"); 
         
        }

        private void 登录信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(name,quanxian);
            f8.MdiParent = this;
            f8.WindowState = FormWindowState.Maximized;
            f8.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (quanxian == "系统管理员")
            {
                Form13 f13 = new Form13();
                f13.MdiParent = this;
                f13.WindowState = FormWindowState.Maximized;
                f13.Show();

            }
            else if (quanxian == "学生")
            {
                MessageBox.Show("没有权限访问");
            }

            else if (quanxian == "教师")
            {

                Form13 f13 = new Form13();
                f13.MdiParent = this;
                f13.WindowState = FormWindowState.Maximized;
                f13.Show();

            }
            else MessageBox.Show("未知的权限");
    
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
           // Application.Exit();
        }

        private void 添加商品信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(name,quanxian);
            f5.MdiParent= this;
            f5.WindowState = FormWindowState.Maximized;

            f5.Show();
        }

        private void 管理商品信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {


            if (quanxian == "系统管理员")
            {

                Form7 f7 = new Form7();
                f7.MdiParent = this;
                f7.WindowState = FormWindowState.Maximized;
                f7.Show();

            }
            else if (quanxian == "学生")
            {
                MessageBox.Show("学生不能够访问查看用户信息哦 你可以去成绩管理查查自己的信息呢");
            }

            else if (quanxian == "教师")
            {

                MessageBox.Show("教师不能够访问查看用户信息哦");

            }
            else MessageBox.Show("未知的权限");
            


        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {


            if (quanxian == "系统管理员")
            {

                Form5 f5 = new Form5(name, quanxian);
                f5.MdiParent = this;
                f5.WindowState = FormWindowState.Maximized;

                f5.Show();

            }
            else if (quanxian == "学生")
            {
                Form5 f5 = new Form5(name, quanxian);
                f5.MdiParent = this;
                f5.WindowState = FormWindowState.Maximized;

                f5.Show();
            }

            else if (quanxian == "教师")
            {

                Form5 f5 = new Form5(name, quanxian);
                f5.MdiParent = this;
                f5.WindowState = FormWindowState.Maximized;
                f5.Show();

            }
            else MessageBox.Show("未知的权限");
            
            
            
            
            
       
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (quanxian == "系统管理员")
            {

                Form11 f11 = new Form11();
                f11.MdiParent = this;
                f11.WindowState = FormWindowState.Maximized;
                f11.Show();

            }
            else if (quanxian == "学生")
            {
                MessageBox.Show("学生不能够访问查看班级管理哦 你可以去查询处查询自己的成绩呢");
            }

            else if (quanxian == "教师")
            {

                Form11 f11 = new Form11();
                f11.MdiParent = this;
                f11.WindowState = FormWindowState.Maximized;
                f11.Show();

            }
            else MessageBox.Show("未知的权限");


          
        }

        private void 安全退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出？ 请妥善保管好您的工作内容  谢谢使用  我们下次再见", "退出界面", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
if (dr == DialogResult.OK)
{
    System.Environment.Exit(0); 
}
else
{ //点取消的代码 


}
            
        
        }

        private void 成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (quanxian == "系统管理员")
            {

                Form9 f9 = new Form9();
                f9.MdiParent = this;
                f9.WindowState = FormWindowState.Maximized;
                f9.Show();

            }
            else if (quanxian == "学生")
            {
                MessageBox.Show("学生不能够访问查看成绩管理哦 你可以去查询处查询自己的成绩呢");
            }

            else if (quanxian == "教师")
            {

                Form9 f9 = new Form9();
                f9.MdiParent = this;
                f9.WindowState = FormWindowState.Maximized;
                f9.Show();

            }
            else MessageBox.Show("未知的权限");
           
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

            if (quanxian == "系统管理员")
            {

                Form14 f14 = new Form14();
                f14.MdiParent = this;
                f14.WindowState = FormWindowState.Maximized;
                f14.Show();

            }
            else if (quanxian == "学生")
            {
                MessageBox.Show("学生不能够访问查看教师信息哦 ");
            }

            else if (quanxian == "教师")
            {

                MessageBox.Show("教师不能够访问查看其他教师信息哦，你可以去查询处查看自己的教师信息哦");

            }
            else MessageBox.Show("未知的权限");

            
        }
    }
}
