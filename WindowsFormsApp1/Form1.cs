using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (a1 == "X" && a2 == "X" && a3 == "X")
            {
                MessageBox.Show("X ery krin");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public int index = 0;
        int xScore = 0;
        int oScore = 0;
        int noMove = 0;

        public string a1 = "null", a2 = "null", a3 = "null", b1 = "null", b2 = "null", b3 = "null", c1 = "null", c2 = "null", c3 = "null";


        private void label1_Click(object sender, EventArgs e)
        {
            
            label1.Text = indexChange();
            a1 = label1.Text;
            label1.Enabled = false;
            noMove++;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = indexChange();
            label2.Enabled = false;
            a2 = label2.Text;
            noMove++;
        }

        
        
        private void label3_Click(object sender, EventArgs e)
        {
            
            label3.Text = indexChange();
            label3.Enabled = false;
            a3 = label3.Text;
            noMove++;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            
            label4.Text = indexChange();
            label4.Enabled = false;
            b1 = label4.Text;
            noMove++;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = indexChange();
            label5.Enabled = false;
            b2 = label5.Text;
            noMove++;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = indexChange();
            label6.Enabled = false;
            b3 = label6.Text;
            noMove++;
        }
        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = indexChange();
            label7.Enabled = false;
            c1 = label7.Text;
            noMove++;
        }
        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = indexChange();
            label8.Enabled = false;
            c2 = label8.Text;
            noMove++;
        }
        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = indexChange();
            label9.Enabled = false;
            c3 = label9.Text;
            noMove++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (a1 == "X" && a2 == "X" && a3 == "X" ||
                b1 == "X" && b2 == "X" && b3 == "X" ||
                c1 == "X" && c2 == "X" && c3 == "X" ||
                a1 == "X" && b2 == "X" && c3 == "X" ||
                a3 == "X" && b2 == "X" && c1 == "X" ||
                a1 == "X" && b1 == "X" && c1 == "X" ||
                a2 == "X" && b2 == "X" && c2 == "X" ||
                a3 == "X" && b3 == "X" && c3 == "X")
            {
                timer1.Enabled = false;
                MessageBox.Show("X - Winner!");
                xScore++;
                label12.Text = xScore.ToString();
                restart();

            }
            else if (a1 == "O" && a2 == "O" && a3 == "O" ||
                b1 == "O" && b2 == "O" && b3 == "O" ||
                c1 == "O" && c2 == "O" && c3 == "O" ||
                a1 == "O" && b2 == "O" && c3 == "O" ||
                a3 == "O" && b2 == "O" && c1 == "O" ||
                a1 == "O" && b1 == "O" && c1 == "O" ||
                a2 == "O" && b2 == "O" && c2 == "O" ||
                a3 == "O" && b3 == "O" && c3 == "O")
            {

                timer1.Enabled = false;
                MessageBox.Show("O - Winner!");
                oScore++;
                label13.Text = oScore.ToString();
                restart();
            }
            else if (noMove>=9)
            {

                timer1.Enabled = false;
                MessageBox.Show("No Move!");
                restart();
            }
        }
        public string indexChange()
        {
            string value;
            if (index == 0)
            {
                value = "X";
                index = 1;
            }
            else
            {
                value = "O";
                index = 0;
            }
            return value;
        }
        public void restart()
        {
            a1 = ""; a2 = ""; a3 = ""; b1= "";b2 = "";b3 = "";c1 = "";c2 = "";c3 = "";
            index = 0;
            label1.Text = " "; label2.Text = " "; label3.Text = " ";
            label4.Text = " "; label5.Text = " "; label6.Text = " ";
            label7.Text = " "; label8.Text = " "; label9.Text = " ";
            label1.Enabled = true; label2.Enabled = true; label3.Enabled = true;
            label4.Enabled = true; label5.Enabled = true; label6.Enabled = true;
            label7.Enabled = true; label8.Enabled = true; label9.Enabled = true;
            timer1.Enabled = true;
            noMove = 0;
        }
    }
}
