﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinQuestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnno.MouseMove += btnno_MouseMove;
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ми й не сумнівалися, що ви так думаєте!");
        }

        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {
            btnno.Top -= e.Y;
            btnno.Left += e.X;
            if (btnno.Top < 10 || btnno.Top > 100)
                btnno.Top = 60;
            //if (btnno.Left < 1 || btnno.Left > 250)
               // btnno.Left = 120;
            //if (btnno.Top < 0)
            if (btnno.Right < 10 || btnno.Left > 250)
                btnno.Left = 10;
        }
    }
}