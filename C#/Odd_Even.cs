using System;

namespace Program
{
    class Odd_Even
    {
        public static void Run()
        {
            int a;

            Console.WriteLine("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            if (a%2==0)
            {
                Console.WriteLine($"{a} is an Even number...");
            }
            else
            {
                Console.WriteLine($"{a} is an Odd number...");
            }
        }
    }
}