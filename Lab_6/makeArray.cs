using System;
using System.Drawing;

namespace Lab_6
{
	public class ArrayMaker
	{

		public int[] arr;


        public void makeArr(int size)
		{

			arr = new int[size];

			for (int i = 0; i<size; i++)
			{
				Console.Write("Enter the value for the array: ");
				arr[i] = Convert.ToInt32(Console.ReadLine());
				if (i < arr.Length)
				{
                    i += 1;
                    arr[i] = 0;
                }
				
			}
		}

		public void printArr()
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine($"Element [{i}]: {arr[i]}");
			}
		}
	}
}

