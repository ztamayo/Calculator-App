// Zailyn Tamayo
// Calculator App
// 30 October 2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Declare global variables
        double num1 = 0;
        double num2 = 0;

        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;

        // Button 1 click
        private void button1_Click(object sender, EventArgs e)
        {
            // Display number in text box
            textBox1.Text = textBox1.Text + button1.Text;
        }

        // Button 2 click
        private void button2_Click(object sender, EventArgs e)
        {
            // Display number in text box
            textBox1.Text = textBox1.Text + button2.Text;
        }

        // Button 3 click
        private void button3_Click(object sender, EventArgs e)
        {
            // Display number in text box
            textBox1.Text = textBox1.Text + button3.Text;
        }

        // Button 4 click
        private void button4_Click(object sender, EventArgs e)
        {
            // Display number in text box
            textBox1.Text = textBox1.Text + button4.Text;
        }

        // Button 5 click
        private void button5_Click(object sender, EventArgs e)
        {
            // Display number in text box
            textBox1.Text = textBox1.Text + button5.Text;
        }

        // Button 6 click
        private void button6_Click(object sender, EventArgs e)
        {
            // Display number in text box
            textBox1.Text = textBox1.Text + button6.Text;
        }

        // Button 7 click
        private void button7_Click(object sender, EventArgs e)
        {
            // Display number in text box
            textBox1.Text = textBox1.Text + button7.Text;
        }

        // Button 8 click
        private void button8_Click(object sender, EventArgs e)
        {
            // Display number in text box
            textBox1.Text = textBox1.Text + button8.Text;
        }

        // Button 9 click
        private void button9_Click(object sender, EventArgs e)
        {
            // Display number in text box
            textBox1.Text = textBox1.Text + button9.Text;
        }

        // Button 0 click
        private void button0_Click(object sender, EventArgs e)
        {
            // Display number in text box
            textBox1.Text = textBox1.Text + button0.Text;
        }

        // Clear button click
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears text box
            textBox1.Clear();
        }

        // Plus button click
        private void plusButton_Click(object sender, EventArgs e)
        {
            // Plus button clicked is true
            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;

            // Stores first number and clears text box
            num1 += double.Parse(textBox1.Text);
            textBox1.Clear(); 
        }

        // Equal button click
        private void equalButton_Click(object sender, EventArgs e)
        {
            // Checks which operator button was clicked and performs calculation
            if (plusButtonClicked == true)
            {
                // Calculate sum
                num2 = num1 + double.Parse(textBox1.Text);
                
            }
            else if (minusButtonClicked == true)
            {
                // Calculate difference
                num2 = num1 - double.Parse(textBox1.Text);
                
            }
            else if (multiplyButtonClicked == true)
            {
                // Calculate product
                num2 = num1 * double.Parse(textBox1.Text);
             
            }
            else if (divideButtonClicked == true)
            {
                // Calculate quotient
                num2 = num1 / double.Parse(textBox1.Text);
               
            }

            // Display result
            textBox1.Text = num2.ToString();
            num1 = 0;

        }

        // Subtract button click
        private void subtractButton_Click(object sender, EventArgs e)
        {
            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;

            // Stores first number and clears text box
            num1 += double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        // Multiply button click
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;

            // Stores first number and clears text box
            num1 += double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        // Divide button click
        private void divideButton_Click(object sender, EventArgs e)
        {
            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;

            // Stores first number and clears text box
            num1 += double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        // Exit button click
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exits program
            this.Close();
        }

        // double button click
        private void decimalButton_Click(object sender, EventArgs e)
        {
            // Displays decimal point
            textBox1.Text = textBox1.Text + ".";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
