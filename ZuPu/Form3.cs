﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZuPu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessList Al = new AccessList();
            Al.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 search = new Form4();
            search.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 manege = new Form5();
            manege.Show();
        }
    }
}
