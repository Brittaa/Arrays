using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[100];
            double sum = 0;
            double average;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                //Console.WriteLine($"{array[i]}");
            }

            foreach (int n in array)
            {
                Console.WriteLine(n);
                sum = sum + n;
                
            }
            /*double average = sum / array.Length;
            Console.WriteLine(sum);
            Console.WriteLine(Math.Round(average, 2));*/
            Console.WriteLine(average = sum / array.Length);


            /*for (int j = 0; j < array.Length; j++)
            {
                sum += array[j];
            }

            Console.WriteLine($"Sum of the array of number 1 to 100 is {sum}.");*/


        }
    }
}