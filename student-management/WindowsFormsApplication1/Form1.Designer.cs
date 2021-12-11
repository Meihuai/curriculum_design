namespace WindowsFormsApplication1
{
    
    partial class Form1
    {

        int i = 1;

        string zhuce;
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.改变颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义字体颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义背景色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于管理系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册激活ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.官方授权ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(104, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(194, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 67);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "huazai";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 118);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "123456";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(273, 120);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = " 隐藏";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(31, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(356, 198);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户验证";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(215)))));
            this.linkLabel1.Location = new System.Drawing.Point(272, 69);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "忘记密码？";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bai1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册ToolStripMenuItem,
            this.改变颜色ToolStripMenuItem,
            this.关于管理系统ToolStripMenuItem,
            this.联系我们ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(414, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("注册ToolStripMenuItem.Image")));
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.注册ToolStripMenuItem.Text = "注册";
            this.注册ToolStripMenuItem.Click += new System.EventHandler(this.注册ToolStripMenuItem_Click);
            // 
            // 改变颜色ToolStripMenuItem
            // 
            this.改变颜色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ziToolStripMenuItem,
            this.背景颜色ToolStripMenuItem,
            this.自定义字体颜色ToolStripMenuItem,
            this.自定义背景色ToolStripMenuItem});
            this.改变颜色ToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.pi;
            this.改变颜色ToolStripMenuItem.Name = "改变颜色ToolStripMenuItem";
            this.改变颜色ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.改变颜色ToolStripMenuItem.Text = "更换皮肤";
            this.改变颜色ToolStripMenuItem.Click += new System.EventHandler(this.改变颜色ToolStripMenuItem_Click);
            // 
            // ziToolStripMenuItem
            // 
            this.ziToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.hei1;
            this.ziToolStripMenuItem.Name = "ziToolStripMenuItem";
            this.ziToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ziToolStripMenuItem.Text = "黑色风格";
            this.ziToolStripMenuItem.Click += new System.EventHandler(this.ziToolStripMenuItem_Click);
            // 
            // 背景颜色ToolStripMenuItem
            // 
            this.背景颜色ToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.mountains_1289_0657894737px_1208281_easyicon_net;
            this.背景颜色ToolStripMenuItem.Name = "背景颜色ToolStripMenuItem";
            this.背景颜色ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.背景颜色ToolStripMenuItem.Text = "金顶云海";
            this.背景颜色ToolStripMenuItem.Click += new System.EventHandler(this.背景颜色ToolStripMenuItem_Click);
            // 
            // 自定义字体颜色ToolStripMenuItem
            // 
            this.自定义字体颜色ToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.custom_reports_256px_521029_easyicon_net;
            this.自定义字体颜色ToolStripMenuItem.Name = "自定义字体颜色ToolStripMenuItem";
            this.自定义字体颜色ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.自定义字体颜色ToolStripMenuItem.Text = "自定义字体颜色";
            this.自定义字体颜色ToolStripMenuItem.Click += new System.EventHandler(this.自定义字体颜色ToolStripMenuItem_Click);
            // 
            // 自定义背景色ToolStripMenuItem
            // 
            this.自定义背景色ToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.mo;
            this.自定义背景色ToolStripMenuItem.Name = "自定义背景色ToolStripMenuItem";
            this.自定义背景色ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.自定义背景色ToolStripMenuItem.Text = "默认风格";
            this.自定义背景色ToolStripMenuItem.Click += new System.EventHandler(this.自定义背景色ToolStripMenuItem_Click);
            // 
            // 关于管理系统ToolStripMenuItem
            // 
            this.关于管理系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册激活ToolStripMenuItem,
            this.官方授权ToolStripMenuItem,
            this.检查更新ToolStripMenuItem});
            this.关于管理系统ToolStripMenuItem.Name = "关于管理系统ToolStripMenuItem";
            this.关于管理系统ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.关于管理系统ToolStripMenuItem.Text = "关于管理系统";
            this.关于管理系统ToolStripMenuItem.Click += new System.EventHandler(this.关于管理系统ToolStripMenuItem_Click);
            // 
            // 注册激活ToolStripMenuItem
            // 
            this.注册激活ToolStripMenuItem.Name = "注册激活ToolStripMenuItem";
            this.注册激活ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.注册激活ToolStripMenuItem.Text = "注册激活";
            this.注册激活ToolStripMenuItem.Click += new System.EventHandler(this.注册激活ToolStripMenuItem_Click);
            // 
            // 官方授权ToolStripMenuItem
            // 
            this.官方授权ToolStripMenuItem.Name = "官方授权ToolStripMenuItem";
            this.官方授权ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.官方授权ToolStripMenuItem.Text = "官方授权";
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            this.检查更新ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.检查更新ToolStripMenuItem.Text = "检查更新";
            // 
            // 联系我们ToolStripMenuItem
            // 
            this.联系我们ToolStripMenuItem.Name = "联系我们ToolStripMenuItem";
            this.联系我们ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.联系我们ToolStripMenuItem.Text = "联系我们";
            this.联系我们ToolStripMenuItem.Click += new System.EventHandler(this.联系我们ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 21);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(96, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "学生信息管理系统";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bai;
            this.ClientSize = new System.Drawing.Size(414, 268);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市库存后台管理系统 未注册";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 改变颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于管理系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册激活ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 官方授权ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义字体颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义背景色ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

