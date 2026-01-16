using System;

namespace Program
{
    class Greater
    {
        public static void Run()
        {
            int a,b;
            Console.WriteLine("Enter the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else
            {
                Console.WriteLine($"{b} is greater than {a}");
            }
        }
    }
}