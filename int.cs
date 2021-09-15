
using System;

namespace exos
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexnum = 2013;
            Console.WriteLine("|{0,-10}|", hexnum);
            double fracpo = 0.256;
            Console.WriteLine("|{0,-10:f2}|", fracpo);
            double fracne = -0.589;
            Console.WriteLine("|{0,-10}|", fracne);
        }
    }
}
