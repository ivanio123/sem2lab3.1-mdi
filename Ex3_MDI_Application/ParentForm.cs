﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3_MDI_Application
{
    public partial class Form1 : Form
    {
        private int _openDocuments = 0;
        
        public Form1()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(DateTime.Today.ToLongTimeString());
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Text = newChild.Text + " " + ++_openDocuments;
            newChild.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm childForm = new ChildForm();
                    childForm.MdiParent = this;
                    childForm.Show();
                    childForm.Text = childForm.Text + "" + ++_openDocuments;
                    break;
                case "Cascade":
                    LayoutMdi(MdiLayout.Cascade);
                    break;
                case "Title":
                    LayoutMdi(MdiLayout.TileHorizontal);
                    break;
            }
        }

        private void spWin_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is cascade";
            spWin.Text = "Windows is horizontal";
        }
    }
}