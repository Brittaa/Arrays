using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myFirstArray = new int[5] { 1, 2, 3, 4, 5 };



            /*for (int i = 0; i < myFirstArray.Length; i++)
            {
                Console.WriteLine(myFirstArray[i]);
            }
            for (int i = myFirstArray.Length -1; i >= 0; i--)
            {
                Console.WriteLine(myFirstArray[i]);
            }*/

            //Overwritting array values

            /*myFirstArray[4] = myFirstArray[4] * 100;
            myFirstArray[0] = myFirstArray[1] * 100;

            for (int i = 0; i < myFirstArray.Length; i++)
            {
                Console.WriteLine(myFirstArray[i]);

            }*/

            for(int i = 0; i < myFirstArray.Length; i++)
            {
                myFirstArray[i] = myFirstArray[i] * 100;
                Console.WriteLine(myFirstArray[i]);
            }
        }
    }
}
