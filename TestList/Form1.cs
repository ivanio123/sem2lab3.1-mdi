using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonAdd.Click += buttonAdd_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonSort.Click += buttonSort_Click;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            foreach ()
            else if (peopleList.Text == memberList.Items.ToString.Text) 
            {
                MessageBox.Show("Такий елемент уже існує");
            }
            else
                MessageBox.Show("Виберіть елемент зі списку або введіть новий");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while(memberList.CheckedIndices.Count > 0)
            {
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }
    }
}