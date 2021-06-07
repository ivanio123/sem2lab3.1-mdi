using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result;
            Form2 form2 = new Form2();
            result = form2.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Your name is " + form2.textBox1.Text + " " + form2.textBox2.Text);
                MessageBox.Show("Your address is " + form2.textBox3.Text);
                MessageBox.Show("Your phone number is " + form2.maskedTextBox1.Text);
            }

            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.google.com");
            linkLabel2.LinkVisited = true;
        }
    }
}