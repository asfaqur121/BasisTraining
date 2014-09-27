using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Salary
    {
        public string name;
        public double basicSalary;
        public double houseRant;
        public double medicalRant;
        public double totalSalary;


        public double GetTotal()
        {
            double totalSalary = basicSalary + houseRantCalcualte() + medicalRantCalculate();
            return totalSalary;
        }

     
        private double houseRantCalcualte()
        {
           return houseRant = (basicSalary*houseRant)/100;
        }

        private double medicalRantCalculate()
        {
           return medicalRant = (basicSalary*medicalRant)/100;
        }

    }
}
