using System;

namespace YearValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year were you born at?");
            string userYear = Console.ReadLine();
            

            if (Validate(userYear))
            {
                Age(userYear);
            }
            else
            {
                Console.WriteLine("Wrong format");
            }
        }
        public static bool Validate(string userAge)
        {
            if (userAge.Length == 4)
            {
                try
                {
                    long.Parse(userAge);
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }public static void Age(string userAge)
        {
            int year = Int32.Parse(userAge);
            DateTime now = DateTime.Today;
            int age = now.Year - year;
            Console.WriteLine($"You are {age} years old");
        }
    }
}
