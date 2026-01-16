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

            if (num > 0)
            {
                Console.WriteLine($"{num} is a Positive Number...");
            }
            else if (num == 0)
            {
                Console.WriteLine($"{num} is a Zero...");
            }
            else
            {
                Console.WriteLine($"{num} is a Negative Number...");
            }

        }
    }
}