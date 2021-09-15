using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
            //Write a program that reads five numbers from the console and prints the
                //greatest of them.
        {
            int x = 0;
            int y = 0;
            int z = 0;
            int n = 0;
            int m = 0;

            Console.WriteLine(" enter number 1: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter number 2: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter number 3: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter number 4: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter number 5: ");
            m = Convert.ToInt32(Console.ReadLine());

            int maximum = Math.Max(x, Math.Max(z, Math.Max(y, Math.Max(n, m))));

            Console.WriteLine("The biggest number is " + maximum);
        }
    }
}
