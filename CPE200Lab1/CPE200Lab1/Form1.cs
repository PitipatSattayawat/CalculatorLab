using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        string Godnew;
        double eiei, Result;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }


        private void btn4_Click(object sender, EventArgs e)
        {

        }


        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "0";
            }
            else
            {
                lblDisplay.Text += "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            eiei = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            Godnew = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            eiei = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            Godnew = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            eiei = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            Godnew = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            eiei = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            Godnew = "/";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains('.') == false)
            {
                lblDisplay.Text += ".";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double eiei2;

            eiei2 = Convert.ToDouble(lblDisplay.Text);

            if (Godnew == "+")
            {
                Result = (eiei + eiei2);

                eiei = Result;
            }
            if (Godnew == "-")
            {
                Result = (eiei - eiei2);

                eiei = Result;
            }
            if (Godnew == "*")
            {
                Result = (eiei * eiei2);

                eiei = Result;
            }
            if (Godnew == "/")
            {
                if (eiei2 == 0)
                {
                    lblDisplay.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (eiei / eiei2);

                    eiei = Result;
                }
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text = Convert.ToString(Result);
            }
            if (lblDisplay.Text.Length > 8)

            {
                lblDisplay.Text = "Erorrrr!";
            }
        }
        private void btNumbereiei(object sender, EventArgs e)
        {
           if(lblDisplay.Text == "0")
            {
                lblDisplay.Text = ((Button)sender).Text;
            }
            else if(lblDisplay.Text.Length<8)
            {
                lblDisplay.Text += ((Button)sender).Text;
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double eiei2; 
            eiei2 = double.Parse(lblDisplay.Text);
            eiei2 = (eiei2 / 100) * eiei;
            if (Godnew == "+")
            {
                Result = eiei + eiei2;
            }
            else if (Godnew == "-")
            {
                Result = eiei - eiei2;
            }
            lblDisplay.Text = Result.ToString();
        }
    }
}
        
