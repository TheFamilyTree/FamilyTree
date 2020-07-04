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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            AccessHelp AH = new AccessHelp();
            string sql = "select * from [Member] where [姓名] = '"+name+"'";
            var ds = AH.GetDS(sql);
            if (ds != null && ds.Tables.Count > 0)
            {
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccessHelp AH = new AccessHelp();
            string sql = "select * from [Member]";
            var ds = AH.GetDS(sql);
            if (ds != null && ds.Tables.Count > 0)
            {
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
