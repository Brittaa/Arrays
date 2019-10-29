using System;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int yearOfBirth;
            int age;

            Console.WriteLine("Enter your year of birth: ");
            yearOfBirth = int.Parse(Console.ReadLine());
            age = CalculateAge(yearOfBirth, 2019);
            Console.WriteLine($"You are {age} years old.");

            int ageNextYear = CalculateNextYearAge(age);
            Console.WriteLine($"Next year you are {ageNextYear}.");

            CompareYourAge(yearOfBirth);
           

        }

        public static int CalculateAge(int yearOfBirth, int currentYear)
        {
            /*int result = currentYear - yearOfBirth;
            return result;*/
            return currentYear - yearOfBirth;
        }
        public static int CalculateNextYearAge(int userAge)
        {
            return userAge + 1;
        }

        public static void CompareYourAge(int yearOfBirth)
        {
            if (yearOfBirth > 1926)
            {
               Console.WriteLine($"You are {yearOfBirth - 1926} years younger than the Queen Elizabeth."); //Math.Abs(valem) 
            }
            else if (yearOfBirth == 1926)
            {
                Console.WriteLine("Are you the Queen?");
            }
            else
            { 
                Console.WriteLine($"You are {1926 - yearOfBirth} year(s) older than the Queen Elizabeth.");
            }
            
        }
    }
}
