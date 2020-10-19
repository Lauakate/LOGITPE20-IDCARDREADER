﻿using System;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID code:");
            string usersID = Console.ReadLine();

            if (Validate(usersID))
            {
                Console.WriteLine("Welcome!");
                HelloUser(usersID);
            } else
            {
                Console.WriteLine("Wrong format. Try again.");
            }
        }
        public static bool Validate(string idCode)
        {
            if (idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                } 
                catch(Exception e)
                {
                    Console.WriteLine($"Wrong formar: {e}");
                    return false;
                }
                
            } else
            {
                return false;
            }
            
        }

        public static void HelloUser(string idCode)
        {
            int firstNum = Int32.Parse(idCode[0].ToString());
            // || - alt gr + <>
            if(firstNum == 1 || firstNum == 3 || firstNum == 5 )
            {
                Console.WriteLine("Hello, Sir!");
            } else if (firstNum == 2 || firstNum == 4 || firstNum == 6)
            {
                Console.WriteLine("Hello, Madam!");
            }
        }

    }
}
