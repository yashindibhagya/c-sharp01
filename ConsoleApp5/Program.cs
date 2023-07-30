using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 01
            Class1 converter = new Class1();
            converter.kilometerToMeter();

            //Question 02
            Class1 converter = new Class1();

            Console.Write("Enter the distance in kilometers (km): ");
            if (double.TryParse(Console.ReadLine(), out double kilometers))
            {
                converter.kilometerToMeter(kilometers);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value for kilometers.");
            }


            //Question 03
            Class1 converter = new Class1();

            Console.Write("Enter the distance in kilometers (km): ");
            if (double.TryParse(Console.ReadLine(), out double kilometers))
            {
                double meters = converter.kilometerToMeter(kilometers);
                Console.WriteLine($"The equivalent distance in meters (m) is: {meters} m");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value for kilometers.");
            }

        }
    }
}
