using System;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {

            /*String[] myFirstStringArray = new string[5] {"one", "two", "three", "four", "five"};

            for(int i = 0; i < myFirstStringArray.Length; i++)
            {
                Console.WriteLine(myFirstStringArray[i]);
            }
            for (int i = myFirstStringArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(myFirstStringArray[i]);
            }
            */

            String[] fruits = new string[5];

            for (int i = 0; i <5; i++)
            {
                Console.WriteLine("Name some fruit: ");
                fruits[i] = Console.ReadLine();
            }

            foreach(string fruit in fruits)
            {
                Console.WriteLine($"You have entered: {fruit}");
            }

        }
    }
}
