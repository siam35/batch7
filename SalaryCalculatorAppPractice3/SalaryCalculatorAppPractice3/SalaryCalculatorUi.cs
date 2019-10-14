using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }
        SalaryCount salarycount = new SalaryCount();
        double amount;
        double rent;
        double medical;
        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            salarycount.employeeName = employeeNameTextBox.Text;
            salarycount.basic=Convert.ToDouble(basicAmountTextBox.Text);
            salarycount.houserentpercentage = Convert.ToDouble(homeRentTextBox.Text);
            salarycount.medicalallowancepercentage = Convert.ToDouble(medicalAllowanceTextBox.Text);



          string message = salarycount.employeeName + " " + "your salary is " + salarycount.getSalary();
            //  string message2 = "Basic: " + salarycount.basic;
            
            MessageBox.Show(message);

        }
    }
}
