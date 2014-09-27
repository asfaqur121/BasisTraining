using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUi : Form
    {
        public CalculatorUi()
        {
            InitializeComponent();
        }

        Calculator aCalculator= new Calculator();

        public void SetValue()
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTxtBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTxtBox.Text);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            SetValue();
            resultTxtBox.Text=aCalculator.Add().ToString();
        }

       

        private void substractButton_Click(object sender, EventArgs e)
        {
            SetValue();
            resultTxtBox.Text = aCalculator.Substract().ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            SetValue();
            resultTxtBox.Text = aCalculator.Multiply().ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            SetValue();
            resultTxtBox.Text = aCalculator.Divide().ToString();
        }
    }
}
