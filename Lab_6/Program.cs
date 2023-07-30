using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            ArrayMaker arrMaker = new ArrayMaker();
            arrMaker.makeArr(size);
            arrMaker.printArr();

        }
    }
}
