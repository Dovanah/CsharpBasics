using System;

namespace EXERCICE9
{
    class Program
    {
        //Write a program that reads an integer number n from the console. After
       // that reads n numbers from the console and prints their sum.
        static void Main(string[] args)
        {
            int n = 3;
            int i = 0;
            int[] tab = new int[n];
            int y = 0;

            while (i < n)
            {

                Console.WriteLine("Please enter the value for the case number " + i);

                tab[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number corresponding to the case number " + i + " is : " + tab[i]);

                y = y + tab[i];

                i++;
            }

            Console.WriteLine("The sum of all the previous numbers is : " + y);
        }
    }
}
