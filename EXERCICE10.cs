using System;

namespace ConsoleApp1
{
    class Program
    {
        //10. Write a program that reads an integer number n from the console and
        //prints all numbers in the range[1…n], each on a separate line.
        static void Main(string[] args)
        {
            int n = 5;
            int i = 0;
            int[] tab = new int[n];
            int j = 0;
            while (i < n)
            {

                Console.WriteLine("Please enter the value for the case number " + i);

                tab[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number corresponding to the case number " + i + " is : " + tab[i]);


                i++;
            }

            while (j < n)
            {
                Console.WriteLine("The value corresponding to the case number " + j + " is : " + tab[j]);
                j++;

            }
        }
    }
}
