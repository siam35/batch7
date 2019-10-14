using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        Calculator aCalculator = new Calculator();
        public CalculatorUi()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string Message = aCalculator.Add(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
            resultTextBox.Text = Message;
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            string Message = aCalculator.Subtract(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
            resultTextBox.Text = Message;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            string Message = aCalculator.Multiply(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
            resultTextBox.Text = Message;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            string Message = aCalculator.Division(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
            resultTextBox.Text = Message;
        }
    }
}
