using System;

namespace ArrayStaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new string[5] { "apple", "banana", "pear", "orange", "lemon"};
            PrintArray(fruit);
           

            //Get the elemnet index
            int index;
            string userInput;
            
            index = Array.IndexOf(fruit, "orange");
            
            Console.WriteLine($"The index of your element is: {index}");

            Console.Write("Enter a fruit: ");
            userInput = Console.ReadLine();
            index = Array.IndexOf(fruit, userInput);

            if (index == -1)
            {
                Console.WriteLine("Your fruit is not in my array.");
            }
            else
            {
                Console.WriteLine(index);
            }




            //string[] colors = new string[5];
            /*for(int i = 0; i < colors.Length; i++)
            {
                Console.Write("Enter a color: ");
                colors[i] = Console.ReadLine();
            }

            //Sort an array
            Array.Sort(colors);
            Console.WriteLine("\n");

            PrintArray(colors);
            Console.WriteLine("\n");

            //Reverse an array
            Array.Reverse(colors);
            Console.WriteLine("Array reversed: ");
            PrintArray(colors);
            Console.WriteLine("\n");

            /*foreach (string color in colors)
            {
                Console.WriteLine(color);
            }*/
        }
        public static void PrintArray(string[] array)
        {
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
