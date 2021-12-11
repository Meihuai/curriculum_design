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
    public partial class Form5 : Form
    {

        byte[] cComment;
        public Form5(string name,string quanxian)
        {
            InitializeComponent();
           
            label7.Text = "登录时间:" + DateTime.Now;
           // comboBox1.SelectedIndex = 0;
             label6.Text = "尊敬的:" + name + "你好~";
             button1.BackColor = Color.Transparent;
             groupBox1.BackColor = Color.Transparent;
             linkLabel1.BackColor = Color.Transparent;
             button2.BackColor = Color.Transparent;
             label7.BackColor = Color.Transparent;
             label6.BackColor = Color.Transparent;
             label11.BackColor = Color.Transparent;
             label10.BackColor = Color.Transparent;
             DataClasses1DataContext db = new DataClasses1DataContext();
             if (quanxian == "学生")
             {
                 textBox1.Text = name;
       
              

                 var q = from m in db.Table_1
                         where m.Cid == textBox1.Text
                         select m;

                 foreach (var v in q)
                 {
             
                     textBox1.Text = v.Cid;                       //商品编号
                     textBox6.Text = v.Cname;                     //商品名称
                     comboBox1.Text = v.Csaleprice;  //销售价格
                     textBox4.Text = v.Cprice.ToString();    //进入价格
                     textBox5.Text = v.Cqty.ToString();              //数量 
                     comboBox1.Text = v.Ctype;                    //属性
                     richTextBox1.Text = v.Cpicture;              //备注   

                     SqlConnection conn = new SqlConnection("Data Source=20180402-211622;Initial Catalog=Test;Integrated Security=TRUE");

                     conn.Open();

                     string sql = string.Format("select Ccomment from Table_1 where Cid='{0}'", textBox1.Text);
                     SqlCommand cmd = new SqlCommand(sql, conn);

                     SqlDataReader reader = cmd.ExecuteReader();

                     reader.Read();

                     MemoryStream buf = new MemoryStream((byte[])reader[0]);

                     Image image = Image.FromStream(buf, true);

                     pictureBox2.Image = image;


                     button2.Text = "修改";
                 }
              //   textBox1.ReadOnly = true;    
                // textBox4.ReadOnly = true;
              //   textBox5.ReadOnly = true;
                 dataGridView1.Visible = false;
                 label11.Visible = true;
                 label10.Visible = true;
             }

         
             this.dataGridView1.Size = new System.Drawing.Size(782, dataGridView1.Height * 2 -10);
        }
     

        private void Form5_Load(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Table_1;
        
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "民族";
            dataGridView1.Columns[4].HeaderText = "班级";
            dataGridView1.Columns[5].HeaderText = "电话";
            dataGridView1.Columns[6].HeaderText = "备注";
            dataGridView1.Columns[7].HeaderText = "图片";
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 70;

           
            var w = (from name in db.Table_2 select  name).ToList();
            foreach (var v in w)
                comboBox1.Items.Add(v.name);
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
           // var q = (from m in db.Table_1 select m).ToList();
         //   dataGridView1.DataSource = q;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string cId = textBox1.Text;                       //学生编号
            string cName = textBox6.Text;                     //学生姓名
            string cSalePrice = comboBox2.Text;               //性别
            string cBuyPrice = textBox4.Text;                 //名族
            string cQty = textBox5.Text;                      //电话
            string cType = comboBox1.Text;                    //所属班级
            string cPicture = richTextBox1.Text;              //备注  
     
            string but3 = this.button2.Text;

            DataClasses1DataContext db = new DataClasses1DataContext();



            if (but3.Equals("添加"))
            {
                // string connString = "Data Source=222-089;Initial Catalog=Test;Integrated Security=TRUE";
                string connString = "Data Source=20180402-211622;Initial Catalog=Test;Integrated Security=TRUE";
  
                SqlConnection connection = new SqlConnection(connString);

                string sql = "insert into Table_1 values(@Id,@Name,@SalePrice,@BuyPrice,@Type,@Qty,@Picture,@Comment)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@Id", cId);
                cmd.Parameters.Add("@Name", cName);
                cmd.Parameters.Add("@SalePrice", cSalePrice);
                cmd.Parameters.Add("@BuyPrice", cBuyPrice);
                cmd.Parameters.Add("@Type", cType);
                cmd.Parameters.Add("@Qty", cQty);
                cmd.Parameters.Add("@Picture", cPicture);
                cmd.Parameters.Add("@Comment", cComment);
                try
                {
                    connection.Open();  // 打开数据库连接
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    { MessageBox.Show("添加成功");
                    dataGridView1.DataSource = db.Table_1;
                   
                      //textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
                    }
                    else MessageBox.Show("添加失败");
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
            else
            {
           
               

                var q = from m in db.Table_1
                        where m.Cid == textBox1.Text
                        select m;

                foreach (var v in q)
                {

               

                    v.Cid = textBox1.Text;                        //学生编号
                    v.Cname = textBox6.Text;                     //学生姓名
                    v.Csaleprice = comboBox2.Text;               //性别
                    v.Cprice = textBox4.Text;                    //民族
                    v.Cqty = textBox5.Text;                       ///电话
                    v.Ctype = comboBox1.Text;                    //所属班级
                    v.Cpicture   =  richTextBox1.Text;              //备注   
              
                }
                try 
                
                {
                    db.SubmitChanges();
                    MessageBox.Show("修改成功");
                    dataGridView1.DataSource = db.Table_1;               
                }
                catch(Exception ex){

                    MessageBox.Show(ex.Message);
                }
                
            
            
            }

        }


        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int ip=0;
            DataClasses1DataContext db = new DataClasses1DataContext();
            
            var q = from m in db.Table_1
                    where m.Cid == textBox1.Text  
                    select m;
           
            foreach (var v in q)
            {
                ip=1;
                textBox1.Text = v.Cid;                       //商品编号
                textBox6.Text = v.Cname;                     //商品名称
                comboBox1.Text = v.Csaleprice;  //销售价格
                textBox4.Text = v.Cprice.ToString();    //进入价格
                textBox5.Text = v.Cqty.ToString();              //数量 
                comboBox1.Text = v.Ctype;                    //属性
                richTextBox1.Text = v.Cpicture;              //备注   

                SqlConnection conn = new SqlConnection("Data Source=20180402-211622;Initial Catalog=Test;Integrated Security=TRUE");

                conn.Open();

                string sql = string.Format("select Ccomment from Table_1 where Cid='{0}'", textBox1.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                MemoryStream buf = new MemoryStream((byte[])reader[0]);

                Image image = Image.FromStream(buf, true);

                pictureBox2.Image = image;


                button2.Text = "修改";


            }
            if (ip != 1)
            {
             
                textBox6.Text ="";                    
            
                textBox4.Text ="";                      
                textBox5.Text ="";                       
           //   comboBox1.SelectedIndex = 0;                 
                richTextBox1.Text = "";
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
                this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
                button2.Text = "添加";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         




           OpenFileDialog openfile = new OpenFileDialog();

           openfile.Title = " 请选择客户端longin的图片";
           openfile.Filter = "Login图片 (*.jpg;*.bmp;*png)|*.jpeg;*.jpg;*.bmp;*.png|AllFiles(*.*)|*.*";
           if (DialogResult.OK == openfile.ShowDialog())
           {
             
               try
               {
                   string filePath = openfile.FileName;//图片路径
                   FileStream fs = new FileStream(filePath, FileMode.Open);
                   byte[] imageBytes = new byte[fs.Length];
                   BinaryReader br = new BinaryReader(fs);
                   imageBytes = br.ReadBytes(Convert.ToInt32(fs.Length));//图片转换成二进制流

                   cComment = imageBytes;
                   fs.Close();
                   fs.Dispose();
               }

               catch (SqlException ex)
               {
                   MessageBox.Show(ex.Message);
               }
               finally
               {
                   pictureBox2.Image = Image.FromFile(openfile.FileName);
                   linkLabel1.Text = "已选图片 点击更换";
               } 
           }
            
           
               

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var q = from m in db.Table_1
                    where m.Cid == textBox1.Text
                    select m;

            foreach (var v in q)
            {

                db.Table_1.DeleteOnSubmit(v);
            }
            try
            {
                db.SubmitChanges();
                MessageBox.Show("删除成功");
                dataGridView1.DataSource = db.Table_1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
