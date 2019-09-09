using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="";
            string val;
            
            string address ="";
             string contanct ="";
             Console.WriteLine("Please Enter Your Name: ");
             name = Console.ReadLine();
            Console.Write("Enter your age: ");
            val = Console.ReadLine();

            int age = Convert.ToInt32(val);
      
             Console.WriteLine("Please Enter Your address: ");
             address = Console.ReadLine();
             Console.WriteLine("Please Enter Your contact: ");
             contanct = Console.ReadLine();
             Console.WriteLine("Name: " + name);
             Console.WriteLine("Your age is: {0}", age);
             Console.WriteLine("Address: " + address);
             Console.WriteLine("Contact no: " + contanct);
             Console.ReadKey();
             
        }
    }
}
