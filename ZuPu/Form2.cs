using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ZuPu.DBHelp;

namespace ZuPu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入账号");
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("请输入密码");
            }
            else if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("请确认密码");
            }
            else if (textBox2.Text == textBox3.Text)
            {
                var yhm = textBox1.Text;
                var pwd = textBox2.Text;
                var sql = "select * from [User] where Yhm = '" + yhm + "' and Pwd = '" + pwd + "'";
                AccessHelp AH = new AccessHelp();
                var dt = AH.GetDT(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("该用户名已被注册！");
                }
                else
                {
                    var sql2 = "insert into [user]([Yhm],[Pwd]) values('"+yhm+"','"+pwd+"') ";
                    AccessHelp AH2 = new AccessHelp();
                    AH2.RunSql(sql2);
                    MessageBox.Show("注册成功！");
                }
            }
            else
            {
                MessageBox.Show("密码错误。");
            }
        }
    }
}
