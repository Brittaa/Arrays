using System;

namespace MinMaxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 3, 6, 38, 56, 17};

            int index;
            int minNumber = Int32.MaxValue;
            int maxNumber = Int32.MinValue;

            foreach (int number in numbers)
            {
                if(number < minNumber)
                {
                    minNumber = number;
                }
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine($"The minium value is {minNumber}");
            Console.WriteLine($"The maximum value is {maxNumber}");



        }
    }
}
