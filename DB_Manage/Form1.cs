﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Manage
{
    public partial class frmDBEdit : Form
    {
        public frmDBEdit()
        {
            InitializeComponent();
        }
        private void Assign()
        {

        }

        private void BtnChooseDB_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (labelControl4.Text == "Yasin")
            {
                labelControl4.Text = "Deneme";
            }
            else
            {
                labelControl4.Text = "Yasin";
            }
        }
    }
}
