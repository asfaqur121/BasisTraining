using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryUI : Form
    {
        Salary aSalary=new Salary();
        public SalaryUI()
        {
            InitializeComponent();
        }

        private void totalSalaryShowButton_Click(object sender, EventArgs e)
        {
            aSalary.name = nameTextBox.Text;
            aSalary.basicSalary = Convert.ToDouble(amountTextBox.Text);
            aSalary.houseRant = Convert.ToDouble(houseRantTextBox.Text);
            aSalary.medicalRant = Convert.ToDouble(medicalRantTextBox.Text);

            double totalSalaryCalculaton=aSalary.GetTotal();
            MessageBox.Show(totalSalaryCalculaton.ToString());
        }
    }
}
