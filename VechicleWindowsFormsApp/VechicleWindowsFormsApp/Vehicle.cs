using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleWindowsFormsApp
{
   public class Vehicle
    {
        public string Name { set; get; }
        public string RegNo { set; get; }
     //   public double Speed { set; get; }

     public List<double>Speed = new List<double>{};
        
        public Vehicle()
        {

        } 

        public Vehicle(string name, string regNo)
        {
            this.Name = name;
            this.RegNo = regNo;
        }

        public List<double> Addspeed(double speed)
        {
            
                Speed.Add(speed);
            
                
            
            
            return Speed;
        }

        public double Maxspeed()
        {
            return Speed.Max();
        }
        public double Minspeed()
        {
            return Speed.Min();
        }
        public double Averagespeed()
        {
            return Speed.Average();
        }
    }
}
