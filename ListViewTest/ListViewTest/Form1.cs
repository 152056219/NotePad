using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                listView1.Sorting = SortOrder.Descending;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listView1.Sorting = SortOrder.Ascending;
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            for(int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                s += listView1.SelectedItems[i].Text;
            }
            label.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text, 1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count > 0) {
            //    label.Text = listView1.SelectedItems[0].Text;
            //}

            string s = "";
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                s += listView1.SelectedItems[i].Text;
            }
            label.Text = s;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                listView1.View = View.LargeIcon;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                listView1.View = View.SmallIcon;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                listView1.View = View.Details;
            }
        }
    }
}
