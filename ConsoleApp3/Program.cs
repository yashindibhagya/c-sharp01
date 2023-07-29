using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 01
            Console.WriteLine("Question 01");
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                double sum = number1 + number2;
                Console.WriteLine("Sum: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid inputs. Please enter valid numbers.");
            }
            Console.ReadKey();

            
            //Question 02
            Console.WriteLine("Question 02");
            
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                double sum = number1 + number2;
                Console.WriteLine("Sum: " + sum);
                double subtraction = number1 - number2;
                Console.WriteLine("Subtraction: " + subtraction);
                double multiplication = number1 * number2;
                Console.WriteLine("Multiplication: " + multiplication);
                if (number2 != 0)
                {
                    double division = number1 / number2;
                    Console.WriteLine("Division: " + division);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid inputs. Please enter valid numbers.");
            }
            Console.ReadKey();

            //Question 03
            Console.WriteLine("Question 03");

            Console.Write("Enter the radius of the circle: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double radius))
            {
                double area = Math.PI * Math.Pow(radius, 2);
                double circumference = 2 * Math.PI * radius;
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Circumference: " + circumference);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the radius.");
            }
            Console.ReadKey();

            //Question 04
            Console.WriteLine("Question 04");

            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " is an even number.");
                }
                else
                {
                    Console.WriteLine(number + " is an odd number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            Console.ReadKey();



            //Question 05
            Console.WriteLine("Question 05");
            
            const int numberOfInputs = 10;
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 1; i <= numberOfInputs; i++)
            {
                Console.Write("Number " + i + ": ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine(number + " is an even number.");
                    }
                    else
                    {
                        Console.WriteLine(number + " is an odd number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for Number " + i + ".");
                    i--;
                }
            }
            Console.ReadKey();
        }
    }
}
