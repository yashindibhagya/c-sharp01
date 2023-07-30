using System;
namespace lab_6
{
	public class arrayCalculator

	{

		int[] arr1;
		int[] arr2;

		public arrayCalculator(int size)
		{
			arr1 = new int[size];
			arr2 = new int[size];
		}

        public void createArr()
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Enter element {i} for 1 array: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Enter element {i} for 2 array: ");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

            public void Scalar_sum ()
		{
			int[] sum = new int[2];
			
			for (int i = 0; i < arr1.Length; i++)
			{
				sum[0] += arr1[i];
				sum[1] += arr2[i];
			}

            Console.WriteLine($"Scalar Sum of 1st Array: {sum[0]}");
            Console.WriteLine($"Scalar Sum of 2nd Array: {sum[1]}");

        }

        public void Vector_sum()
        {
            int[] sum = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                sum[i] = arr1[i] + arr2[i];
                
            }

            Console.Write("Vector Sums of the 2 arrays: ");

            foreach (int element in sum)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }


        public void Vector_product()
        {
            int[] product = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                product[i] = arr1[i] * arr2[i];

            }
            
            Console.Write("Vector Products of the 2 arrays: ");

            foreach(int element in product)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();


        }


        public void Scalar_product()
        {
            int[] product = new int[arr1.Length];
            int sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                product[i] = arr1[i] * arr2[i];

            }

            for (int i = 0; i < product.Length; i++)
            {
                sum += product[i];

            }

            Console.WriteLine($"Scalar Product of the 2 arrays: {sum}");
        }



    }
}

