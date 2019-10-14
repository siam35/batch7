using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    public class SalaryCount
    {
        public string employeeName;
        // public double salary;
        public double basic;
        public double houserentpercentage;
        public double medicalallowancepercentage;
       

        private double getMedicalAllowanceAmount(double medical)
        {
            double medicalAmount = (basic / 100) * medical;
            return medicalAmount;

        }
        private double getHouseRentAmount(double rent)
        {
            double houseRentAmount = (basic / 100) * rent;
            return houseRentAmount;
        }
        private double getBasicAmount()
        {
         //   basic = this.basic;
            return basic;

        }

        public double getSalary()
        {
            //double salary = basic + (basic / 100) * houserentpercentage + (basic / 100) * medicalallowancepercentage;
            //return salary;
            double sbasic = getBasicAmount();
            double srent = getHouseRentAmount(houserentpercentage);
            double smedical = getMedicalAllowanceAmount(medicalallowancepercentage);

            double salary = sbasic + srent + smedical;
            return salary;

        }

    }
}
