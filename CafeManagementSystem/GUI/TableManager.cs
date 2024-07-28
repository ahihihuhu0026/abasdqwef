﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem.GUI
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void thôngTinCaNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile f = new AccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.ShowDialog();
        }


    }
}
