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
using System.Configuration;
using ZuPu.DBHelp;

namespace ZuPu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bu_zhuce_Click(object sender, EventArgs e)
        {
            Form2 Rigistr = new Form2();
            Rigistr.Show();
        }

        private void bu_denglu_Click(object sender, EventArgs e)
        { 
            var yhm = tB_zhanghao.Text;
            var pwd = tB_pwd.Text;
            if (tB_zhanghao.Text == "sa" && tB_pwd.Text == "123456")
            {
                Form3 Manage = new Form3();
                Manage.Show();
            }
            else if(!string.IsNullOrEmpty(yhm) && !string.IsNullOrEmpty(pwd))
            {
                var sql = "select * from [User] where Yhm = '"+ yhm +"' and Pwd = '"+pwd+"'";
                AccessHelp AH = new AccessHelp();
                var dt = AH.GetDT(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    Form4 search = new Form4();
                    search.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名不存在或密码错误！");
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
