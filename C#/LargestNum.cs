using System;

namespace Program
{
    class LargestNum
    {
        public static void Run()
        {
            //largest out of 3 numbers
            int num1, num2, num3;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 & num1 > num3)
            {
                Console.WriteLine($"{num1} is the largest number...");
            }
            else if (num2>num3 & num2>num1)
            {
                Console.WriteLine($"{num2} is the largest number...");
            }
            else
            {
                Console.WriteLine($"{num3} is the largest number...");
            }
        }
    }
}