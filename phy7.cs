using System;

namespace physicsu
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine(" enter an integer number 1: ");
            long x = long .Parse(Console.ReadLine());
            Console.WriteLine(" enter an integer number 2: ");
            long y = long.Parse(Console.ReadLine());
            Console.WriteLine(" enter an integer number 3: ");
            long z = long.Parse(Console.ReadLine());
            Console.WriteLine(" enter an integer number 4: ");
            int n = long.Parse(Console.ReadLine());
            Console.WriteLine(" enter an integer number 5: ");
            long m = long.Parse(Console.ReadLine());

           Console.WriteLine("{0}+{1}+{2}+{3}+{4}={5}", x, y, z, n, m, x + y + z + n + m);

        }
    }
}
