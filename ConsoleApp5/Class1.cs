using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class1
    {
        public void kilometerToMeter()
        {
            //Question 01
            Console.Write("Enter the distance in kilometers (km): ");
            if (double.TryParse(Console.ReadLine(), out double kilometers))
            {
                double meters = kilometers * 1000;
                Console.WriteLine($"The equivalent distance in meters (m) is: {meters} m");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value for kilometers.");
            }

            //Question 02
            double meters = kilometers * 1000;
            Console.WriteLine($"The equivalent distance in meters (m) is: {meters} m");


            //Question 03
            double meters = kilometers * 1000;
            return meters;
        }
    }
}
