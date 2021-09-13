using System;

namespace radius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter r the radius of the cricle");
            int r = int.Parse(Console.ReadLine());

            double per_cir = (double) (2 * Math.PI * r);
            double area = (double) (Math.PI*r*r);
            Console.WriteLine("The perimeter and area of the cirlce are " + per_cir +" and " + area);



        }
    }
}
