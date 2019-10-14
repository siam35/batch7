using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorWindowsFormsApp
{
    public class Refrigeratorweight
    {
        public double MaximumWeightItCanTake { set; get; }
        public int NumberOfItems { set; get; }
        public double WeightPerUnit { set; get; }

        private double remainingWeight;

        public double RemainingWeight
        {
            set
            {
                if (value <= MaximumWeightItCanTake)
                {
                    remainingWeight = value;
                }
                else
                {
                    throw new Exception("Your given amount can't be entered because it will be Over flown.");
                }
            }
            get
            {
                return remainingWeight;
            }
        }

        public double GetCurrentWeight(double items, double weight)
        {
            double currentWeight = items * weight;
            RemainingWeight += currentWeight;

            return RemainingWeight;
        }

        public double GetRemainingWeight()
        {
            double RemainingWeight = (MaximumWeightItCanTake - remainingWeight);
            return RemainingWeight;
        }



    }
}
