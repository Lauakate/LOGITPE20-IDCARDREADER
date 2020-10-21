using System;

namespace CVVValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your credit card validation code:");
            string usersDigits = Console.ReadLine();

            if (Validate(usersDigits))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong format!");
            }
        }
        public static bool Validate(string ValiCode)
        {
            if (ValiCode.Length == 3)
            {
                try
                {
                    long.Parse(ValiCode);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
            } else
            {
                return false;
            }
        }
    }
}
