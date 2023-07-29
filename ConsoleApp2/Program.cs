using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 01
            Console.WriteLine("Question 01");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your batch: ");
            string batch = Console.ReadLine();
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Batch: " + batch);
            Console.ReadKey();

            //Question 02
            Console.WriteLine("Question 02");

            Console.Write("Enter the radius of the circle: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double radius))
            {
                double area = Math.PI * Math.Pow(radius, 2);

                Console.WriteLine("The area of the circle with radius " + radius + " is: " + area);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the radius.");
            }
            Console.ReadKey();

            //Question 03
            Console.WriteLine("Question 03");

            Console.Write("Enter the first value: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second value: ");
            string input2 = Console.ReadLine();
            if (double.TryParse(input1, out double value1) && double.TryParse(input2, out double value2))
            {
                double sum = value1 + value2;
                Console.WriteLine("Sum: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid inputs. Please enter valid numbers.");
            }
            Console.ReadKey();


            //Question 04
            Console.WriteLine("Question 04");

            Console.Write("Enter the salary of the employee: ");
            string salaryInput = Console.ReadLine();
            Console.Write("Enter the tax rate (in decimal format, e.g., 0.2 for 20%): ");
            string taxRateInput = Console.ReadLine();
            if (double.TryParse(salaryInput, out double salary) && double.TryParse(taxRateInput, out double taxRate))
            {
                double salaryAfterTax = salary * (1 - taxRate);
                Console.WriteLine("Salary after tax: " + salaryAfterTax);
            }
            else
            {
                Console.WriteLine("Invalid inputs. Please enter valid numbers for salary and tax rate.");
            }
            Console.ReadKey(); 
        }
    }
}
