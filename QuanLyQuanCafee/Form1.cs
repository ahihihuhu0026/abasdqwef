﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafee
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {

        }

        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();  
            f.ShowDiaLog();
        }
    }
}
