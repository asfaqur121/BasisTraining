using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        public double firstNumber;
        public double secondNumber;

        public double Add()
        {
            return firstNumber + secondNumber;
        }

        public double Substract()
        {
            return firstNumber - secondNumber;
        }

        public double Multiply()
        {
            return firstNumber*secondNumber;
        }

        public double Divide()
        {
            return firstNumber/secondNumber;
        }
    }
}
