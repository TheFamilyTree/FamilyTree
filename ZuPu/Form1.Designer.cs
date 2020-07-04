namespace ZuPu
{
    partial class Form1
    {
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bu_denglu = new System.Windows.Forms.Button();
            this.bu_zhuce = new System.Windows.Forms.Button();
            this.tB_zhanghao = new System.Windows.Forms.TextBox();
            this.tB_pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bu_denglu
            // 
            this.bu_denglu.Font = new System.Drawing.Font("宋体", 12F);
            this.bu_denglu.Location = new System.Drawing.Point(84, 268);
            this.bu_denglu.Name = "bu_denglu";
            this.bu_denglu.Size = new System.Drawing.Size(100, 32);
            this.bu_denglu.TabIndex = 0;
            this.bu_denglu.Text = "登 录";
            this.bu_denglu.UseVisualStyleBackColor = true;
            this.bu_denglu.Click += new System.EventHandler(this.bu_denglu_Click);
            // 
            // bu_zhuce
            // 
            this.bu_zhuce.Font = new System.Drawing.Font("宋体", 12F);
            this.bu_zhuce.Location = new System.Drawing.Point(230, 268);
            this.bu_zhuce.Name = "bu_zhuce";
            this.bu_zhuce.Size = new System.Drawing.Size(100, 32);
            this.bu_zhuce.TabIndex = 1;
            this.bu_zhuce.Text = "注 册";
            this.bu_zhuce.UseVisualStyleBackColor = true;
            this.bu_zhuce.Click += new System.EventHandler(this.bu_zhuce_Click);
            // 
            // tB_zhanghao
            // 
            this.tB_zhanghao.Location = new System.Drawing.Point(219, 116);
            this.tB_zhanghao.Name = "tB_zhanghao";
            this.tB_zhanghao.Size = new System.Drawing.Size(150, 25);
            this.tB_zhanghao.TabIndex = 2;
            // 
            // tB_pwd
            // 
            this.tB_pwd.Location = new System.Drawing.Point(219, 180);
            this.tB_pwd.Name = "tB_pwd";
            this.tB_pwd.Size = new System.Drawing.Size(150, 25);
            this.tB_pwd.TabIndex = 3;
            this.tB_pwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(132, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(132, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(168, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "族谱管理系统";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.Location = new System.Drawing.Point(378, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "退 出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(84, 234);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "记住密码";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(227, 234);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "忘记密码";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.bu_denglu);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.bu_zhuce);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tB_zhanghao);
            this.groupBox1.Controls.Add(this.tB_pwd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 357);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "欢迎";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 377);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "登录";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bu_denglu;
        private System.Windows.Forms.Button bu_zhuce;
        private System.Windows.Forms.TextBox tB_zhanghao;
        private System.Windows.Forms.TextBox tB_pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

