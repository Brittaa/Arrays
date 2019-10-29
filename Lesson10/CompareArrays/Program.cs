using System;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new string[5] { "apple", "banana", "pear", "orange", "lemon" };
            string[] vegetables = new string[5] { "potato", "carrot", "tomato", "onion", "cucumber" };

            Console.WriteLine("Please enter a fruit or vegetable: ");
            string userInput;
            userInput = Console.ReadLine();

            int indexFruit;
            int indexVegetables;
            indexFruit = Array.IndexOf(fruit, userInput);
            indexVegetables = Array.IndexOf(vegetables, userInput);


            if (FruitArray(indexFruit))
            {
                Console.WriteLine("This is a fruit.");
            }
            else if (VegetableArray(indexVegetables))
            {
                Console.WriteLine("This is a vegetable.");
            }
            else
            {
                Console.WriteLine("This is not in my array.");
            }
        }
        public static bool FruitArray(int itemIndex)
        {
            bool result;

            if (itemIndex != -1)
            {
                result = true;
                return result;

            }
            else
            {
                result = false;
                return result;
               
            }
        }
        public static bool VegetableArray(int itemIndex)
        {
            bool result;

            if (itemIndex != -1)
            {
                result = true;
                return result;

            }
            else
            {
                result = false;
                return result;

            }
        }
    }
}
