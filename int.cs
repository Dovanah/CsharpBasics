//Write a program that prints three numbers in three virtual columns on the consoole. Each column should have a width of 10 characters.
//and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third a negative fraction.
//The two numbers have to be rounded to the second decimal place.

using System;

namespace exos
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexnum = 15;
            Console.WriteLine("|{0,-10:x}|", hexnum);
            double fracpo = 0.25;
            Console.WriteLine("|{0,-10:f2}|", fracpo);
            double fracne = -0.59;
            Console.WriteLine("|{0,-10}|", fracne);
        }
    }
}
