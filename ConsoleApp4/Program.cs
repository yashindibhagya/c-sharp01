using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 01
            Console.WriteLine("Question 01");

            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            Console.ReadKey();

            
            
            //Question 02
            Console.WriteLine("Question 02");

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string lowercaseInput = input.ToLower();
            int vowelCount = 0;
            foreach (char c in lowercaseInput)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("Number of vowels in the given string: " + vowelCount);
            Console.ReadKey();


            //Question 03
            Console.WriteLine("Question 03");

            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            if (long.TryParse(input, out long number))
            {
                long sum = 0;
                long tempNumber = Math.Abs(number);
                while (tempNumber > 0)
                {
                    sum += tempNumber % 10;
                    tempNumber /= 10;
                }
                Console.WriteLine("Sum of the digits: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid long integer.");
            }
            Console.ReadKey();


            //Question 04
            Console.WriteLine("Question 04");

            Console.Write("Enter a positive integer: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int n) && n >= 1)
            {
                int sum = 0;

                for (int i = 1; i <= n; i += 2)
                {
                    sum += i;
                }
                Console.WriteLine("Sum of all odd numbers from 1 to " + n + ": " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
