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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
           // button1.BackColor = Color.Transparent;
          //  groupBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.OldLace;
            groupBox1.ForeColor = Color.OldLace;
            groupBox1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
           // button2.BackColor = Color.Transparent;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 fm = new Form12();

            this.Close();//隐藏现在这个窗口

            Form1 f1 = new Form1();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void 改变颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 fm = new Form12();

            this.Close();//隐藏现在这个窗口

            Form1 f1 = new Form1();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void 关于管理系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 fm = new Form12();

            this.Close();//隐藏现在这个窗口

            Form1 f1 = new Form1();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 fm = new Form12();

            this.Close();//隐藏现在这个窗口

            Form1 f1 = new Form1();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void 联系我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 fm = new Form12();

            this.Close();//隐藏现在这个窗口

            Form1 f1 = new Form1();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
