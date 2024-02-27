using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void operationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (double.TryParse(firstNumberTextBox.Text, out double firstNumber) &&
                double.TryParse(secondNumberTextBox.Text, out double secondNumber))
            {

                string selectedOperator = operationComboBox.SelectedItem.ToString();


                double result = 0;
                switch (selectedOperator)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                            result = firstNumber / secondNumber;
                        else
                            MessageBox.Show("Cannot divide by zero!");
                        break;
                }


                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for operands.");
            }
        }

        private void secondNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void computeResultButton_Click(object sender, EventArgs e)
        {

        }

    }
}
