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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        { 
            DataClasses1DataContext db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Table_3;
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "学期";
            dataGridView1.Columns[2].HeaderText = "成绩";
            dataGridView1.Columns[3].HeaderText = "课程";
            dataGridView1.Columns[4].HeaderText = "记录时间";
   
            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 180;
 



            DataClasses1DataContext dx = new DataClasses1DataContext();

            var p = (from Cid in db.Table_1 select Cid).ToList();
            foreach (var v in p)
                comboBox3.Items.Add(v.Cid);

            var w = (from name1 in db.Table_5 select name1).ToList();
            foreach (var v in w)
                comboBox1.Items.Add(v.name1);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
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

  

            Table_3 user = new Table_3();

            user.ID = comboBox3.Text;
            user.pid = comboBox2.Text;                  
            user.qty = int.Parse(textBox1.Text);
       
            user.time = DateTime.Now;
            user.type = comboBox1.Text;
            db.Table_3.InsertOnSubmit(user);

            try
            {
                db.SubmitChanges();
                MessageBox.Show("添加成功");

                dataGridView1.DataSource = db.Table_3;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         

        }

        private void comboBox3_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            int ip = 0;
            DataClasses1DataContext db = new DataClasses1DataContext();

            var q = from m in db.Table_1
                    where m.Cid == comboBox3.Text
                    select m;

            foreach (var v in q)
            {
                ip = 1;

                label4.Text = "学生学号 : " + v.Cid;
                label5.Text = "学生姓名 : " + v.Cname;
                label6.Text = "学生性别 : " + v.Csaleprice;
                label7.Text = "所属民族 : " + v.Cprice;
                label8.Text = "学生电话 : " + v.Cqty;
                label9.Text = "所属班级 : " + v.Ctype;
                label10.Text = "备注 : " + v.Cpicture;

                SqlConnection conn = new SqlConnection("Data Source=20180402-211622;Initial Catalog=Test;Integrated Security=TRUE");

                conn.Open();

                string sql = string.Format("select Ccomment from Table_1 where Cid='{0}'", comboBox3.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                MemoryStream buf = new MemoryStream((byte[])reader[0]);

                Image image = Image.FromStream(buf, true);

                pictureBox2.Image = image;


            }
            if (ip != 1)
            {

                label4.Text = "学生学号";
                label5.Text = "学生姓名";
                label6.Text = "学生性别";
                label7.Text = "所属民族";
                label8.Text = "学生电话";
                label9.Text = "所属班级";
                label10.Text = "备注";
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
                this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            }

        }
    }
}
