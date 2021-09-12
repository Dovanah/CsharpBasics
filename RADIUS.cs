using System;

namespace Somme
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double  r,per_cir;
            Console.WriteLine("enter the radius of a circle: ");
            r = Convert.ToDouble(Console.ReadLine());

            per_cir = 2 * Math.PI * r;
            Console.WriteLine("perimeter of a circle is: {0}", per_cir);
            Console.Read();





        }

        
    }
}
