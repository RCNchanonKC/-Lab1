using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1
{
    public partial class Form1 : Form
    {
        string num1;
        int number = 0;
        string num_str = "";
        string Operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void add_Click(object sender, EventArgs e)
        {

            //add
            string user_input = tb_number.Text;
            tb_number.Text = number.ToString();

        }

        private void clear_Click(object sender, EventArgs e)
        {

            tb_number.Text = string.Empty;
            num_str = string.Empty;                                                                                                                                    
            //clear
        }


        private void num1_Click(object sender, EventArgs e)
        {

            
            num_str += "1";
            tb_number.Text = num_str;
        }

        private void num2_Click(object sender, EventArgs e)
        {

            num_str += "2";
            tb_number.Text = num_str;
        }

        private void num3_Click(object sender, EventArgs e)
        {

            num_str += "3";
            tb_number.Text = num_str;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            num_str += "4";
            tb_number.Text = num_str;

        }

        private void num5_Click(object sender, EventArgs e)
        {
            num_str += "5";
            tb_number.Text = num_str;
        }
        private void num6_Click(object sender, EventArgs e)
        {
            num_str += "6";
            tb_number.Text = num_str;

        }

        private void num7_Click(object sender, EventArgs e)
        {
            num_str += "7";
            tb_number.Text = num_str;

        }

        private void num8_Click(object sender, EventArgs e)
        {
            tb_number.Text = "8";
            num_str += num_str;

        }

        private void num9_Click(object sender, EventArgs e)
        {
            num_str += "9";
            tb_number.Text = num_str;

        }

        private void num0_Click(object sender, EventArgs e)
        {
            num_str += "0";
            tb_number.Text = num_str;

        }


        private void Equalation(object sender, EventArgs e)
        {
            // Result 

            string num2 = tb_number.Text;
            double Num1 = double.Parse(num1);
            double Num2 = double.Parse(num2);

            if (Operator == "+")
            {

                tb_number.Text = String.Format("{0}", Num1 + Num2);

            }
            else if (Operator == "-")
            {

                tb_number.Text = String.Format("{0}", Num1 - Num2);

            }
            else if (Operator == "*")
            {

                tb_number.Text = String.Format("{0}", Num1 * Num2);
            }
            else
            {
                double num = Num1 / Num2;
                tb_number.Text = $"{num:0.00}";
            }
            
            
            

        }
        
        private void plus_Click(object sender, EventArgs e)
        {
            // Plus

            num1 = num_str;
            Operator = "+";
            tb_number.Text = string.Empty;
            num_str = "";


        }

        private void minus_Click(object sender, EventArgs e)
        {

            //minus
            num1 = num_str;
            Operator = "-";
            num_str = "";
            tb_number.Text = string.Empty;
            
            
        
        }

        private void devide_Click(object sender, EventArgs e)
        {
            num1 = num_str;
            tb_number.Text = string.Empty;
            Operator = "/";
            num_str = "";
            // devide

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            num1 = num_str;
            tb_number.Text = string.Empty;
            Operator = "*";
            num_str = "";
            // multiply

        }

        private void tb_number_text(object sender, EventArgs e)
        {

        }

    }


}

