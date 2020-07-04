using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZuPu.DBHelp;

namespace ZuPu
{
    public partial class AccessList : Form
    {
        public AccessList()
        {
            InitializeComponent();
        }

        private void AccessList_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            AccessHelp AH = new AccessHelp();
            string sql = "select * from [User] where Yhm = '"+name+"'";
            var ds = AH.GetDS(sql);
            if(ds!=null&&ds.Tables.Count>0)
            {
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccessHelp AH = new AccessHelp();
            string sql = "select * from [User] ";
            var ds = AH.GetDS(sql);
            if (ds != null && ds.Tables.Count > 0)
            {
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var yhm = textBox2.Text;
            var sql = "select * from [User] where Yhm= '"+yhm+"'";
            AccessHelp AH = new AccessHelp();
            var dt = AH.GetDT(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                var sql2 = "delete form [User] where Yhm='" + yhm + "'";
                AccessHelp AH2 = new AccessHelp();
                AH2.RunSql(sql2);
            }
            else
            {
                MessageBox.Show("没有该成员信息！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var yhm = textBox2.Text;
            var zt = 1;
            var sql = "select * from [User] where Yhm = '" + yhm + "'";
            AccessHelp AH = new AccessHelp();
            var dt = AH.GetDT(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                var sql2 = "update [User] set [zt]= '" + zt + "' where Yhm='" + yhm + "'";
                AccessHelp AH2 = new AccessHelp();
                AH2.RunSql(sql2);
                MessageBox.Show("已冻结！");
            }
            else
            {
                MessageBox.Show("没有该成员信息！");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var yhm = textBox2.Text;
            var zt = 0;
            var sql = "select * from [User] where Yhm = '" + yhm + "'";
            AccessHelp AH = new AccessHelp();
            var dt = AH.GetDT(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                var sql2 = "update [User] set [zt]= '"+zt+"' where Yhm='" + yhm + "'";
                AccessHelp AH2 = new AccessHelp();
                AH2.RunSql(sql2);
                MessageBox.Show("已取消冻结！");
            }
            else
            {
                MessageBox.Show("没有该成员信息！");
            }
        }
    }
}
