using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //textBox2.KeyPress += textBox2_KeyPress;
            if (checkBox1.Checked)
            {
                Label lbl = new Label();
                lbl.Location = new Point(16, 96);
                lbl.Size = new Size(32, 23);
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PІN2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new Point(96, 96);
                txt.Size = new Size(184, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
            }
            else
            {
                int lcv;
                lcv = groupBox1.Controls.Count;
                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (char.IsDigit(e.KeyChar))
           if(Regex.IsMatch(textBox1.Text, @"^[\w@.]*$"))
            {
                e.Handled = true;
                MessageBox.Show("Field name cannot contain any special chars");
                errorProvider1.SetError(textBox1, "Must be letter");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"^\d$").IsMatch(textBox2.Text))
            {
                e.Handled = true;
                MessageBox.Show("Field PIN cannot contain letters");
                errorProvider2.SetError(textBox2, "Must be number");
            }
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
                e.Cancel = false;
            else
                try
                {
                    double.Parse(textBox2.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Field PIN cannot contain letters");
                }
        }
    }
}