using System;
//Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exis, such that the remainder of their division by 5 is 0.

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("enter n :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter m :");
            int m =  int.Parse(Console.ReadLine());
            int x = 0;
           

            while (n<=m) 
            {
                if (n % 5 == 0)
     
                {
                    x = x + 1; 
                }
                n = n + 1;
             
            }

            Console.WriteLine(x);
        }
    }
}

