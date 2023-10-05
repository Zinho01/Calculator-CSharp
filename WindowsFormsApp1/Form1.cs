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

        int num1;
        int num2;
        string operation;
        double result;


        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn6.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn8.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn7.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn9.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtTotal.Text);
            operation = "+";
            
            txtTotal.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtTotal.Text);
            operation = "-";

            txtTotal.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operation = "-";
            if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                num1 = int.Parse(txtTotal.Text);
                txtTotal.Clear();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtTotal.Text);
            operation = "/";

            txtTotal.Clear();
        }

        private void btnMO_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtTotal.Text);
            operation = "%";

            txtTotal.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num1 == 0)
                    {
                        txtTotal.Text = "Kan niet delen door 0";
                            return;
                    }
                    result = num1 / num2;
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        txtTotal.Text = "Kan niet delen door 0";
                    }
                    result = num1 % num2;
                    break;
                default:
                    txtTotal.Text = "Ongeldige operatie";
                    return;
            }
            txtTotal.Text = result + " ";
            
        }
    }
}
