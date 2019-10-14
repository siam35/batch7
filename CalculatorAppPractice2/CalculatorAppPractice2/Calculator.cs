using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    class Calculator
    {
        //public double FirstNumber { set; get; }
        //public double SecondNumber { set; get; }

        public double Add(double FirstNumber,double SecondNumber) { double addedvalue = FirstNumber + SecondNumber; return addedvalue; }
        public double Subtract(double FirstNumber, double SecondNumber) { double Subtractedvalue = FirstNumber - SecondNumber; return Subtractedvalue; }
        public double Multiply(double FirstNumber, double SecondNumber) { double Multipliedvalue = FirstNumber * SecondNumber; return Multipliedvalue; }
        public double Division(double FirstNumber, double SecondNumber) { double Dividedvalue = (FirstNumber / SecondNumber); return Dividedvalue; }
    }
}
