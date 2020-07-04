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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            AccessHelp AH = new AccessHelp();
            string sql = "select * from [Member] where 姓名 = '" + name + "'";
            var ds = AH.GetDS(sql);
            if (ds != null && ds.Tables.Count > 0)
            {
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                MessageBox.Show("至少输入姓名、性别和生日信息。");
            }
            else
            {
                var name = textBox1.Text;
                var gender = textBox2.Text;
                var birth = textBox3.Text;
                var father = textBox4.Text;
                var peiou = textBox5.Text;
                var sql = "select * from [Member] where 姓名 = '" + name + "'and 性别 = '" + gender + "'and 生日 = '" + birth + "'";
                AccessHelp AH = new AccessHelp();
                var dt = AH.GetDT(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("已有该成员信息！");
                }
                else
                {
                    var sql2 = "insert into [Member]([姓名],[性别],[生日],[父亲姓名],[配偶姓名]) values('" + name + "','" + gender + "','" + birth + "','" + father + "','" + peiou + "') ";
                    AccessHelp AH2 = new AccessHelp();
                    AH2.RunSql(sql2);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var gender = textBox2.Text;
            var birth = textBox3.Text;
            var father = textBox4.Text;
            var peiou = textBox5.Text;
            var sql = "select * from [Member] where 姓名 = '" + name + "'and 性别 = '" + gender + "'and 生日 = '" + birth + "'";
            AccessHelp AH = new AccessHelp();
            var dt = AH.GetDT(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                var sql2 = "update [Member] set [性别]='" + gender + "',[生日]='" + birth + "',[父亲姓名]='" + father + "',[配偶姓名]='" + peiou + "' " +
                    "where [姓名]='" + name + "'";
                AccessHelp AH2 = new AccessHelp();
                AH2.RunSql(sql2);
            }
            else
            {
                MessageBox.Show("没有相关成员信息");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var gender = textBox2.Text;
            var birth = textBox3.Text;
            var sql = "select * from [Member] where 姓名 = '" + name + "'and 性别 = '" + gender + "'and 生日 = '" + birth + "'";
            AccessHelp AH = new AccessHelp();
            var dt = AH.GetDT(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                var sql2 = "delete form [Member] where 姓名='"+name+"'，性别='"+gender+"'";
                AccessHelp AH2 = new AccessHelp();
                AH2.RunSql(sql2);
            }
            else
            {
                MessageBox.Show("没有该成员信息！");
            }
        }
    }
}
