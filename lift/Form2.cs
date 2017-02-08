using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lift
{
    public partial class Form2 : Form
    {
        public bool go = false;
        public Form2()
        { 
            InitializeComponent();
        }
        Form1 fo = new Form1();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            label1.Text = "1";
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            label1.Text = "2";
            go = true;
            Close();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            label1.Text = "3";
            go = true;
            Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "4";
            Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "5";
            Close();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "6";
            Close();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "7";
            Close();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "8";
            Close();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "9";
            Close();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "10";
            Close();
        }

     
    }
}
