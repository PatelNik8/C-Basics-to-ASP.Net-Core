using System;

namespace Program
{
    class PosNegZero
    {
        public static void Run()
        {
            int num;

            Console.WriteLine("Enter a number to check whether it is +/-/0: ");
            num = Convert.ToInt16(Console.ReadLine());

            switch(num)
            {
                case 1:
                Console.WriteLine($"{num} is positive number...");
            }

        }
    }
}