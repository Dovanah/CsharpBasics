using System;

namespace exo8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            int n = 0;
            int m = 0;

            Console.WriteLine(" enter number 1: ");
            bool a = false;

            while (a == false)
            {

                try
                {
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("lol");

                    a = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            };
            Console.WriteLine(" enter number 2: ");
            a = false;

            while (a == false)
            {

                try
                {
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("gg");

                    a = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            
                 Console.WriteLine(" enter number 3: ");
            a = false;

            while (a == false)
            {

                try
                {
                    z = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("you're doing it champ");

                    a = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
          
             Console.WriteLine(" enter number 4: ");

            a = false;

            while (a == false)
            {

                try
                {
                    n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("lol");

                    a = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
                        Console.WriteLine(" enter number 5: ");
            a = false;

            while (a == false)
            {

                try
                {
                    m = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("lol");

                    a = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }


            Console.WriteLine("{0}+{1}+{2}+{3}+{4}={5}", x, y, z, n, m, x + y + z + n + m);






        }
    }
}
        


