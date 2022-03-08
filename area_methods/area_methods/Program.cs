using System;

namespace area_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Circle area is {circle(3, 4)} m²");
            Console.WriteLine($"Rectangle area is {rectangle(7, 8)} m²");
            Console.WriteLine($"Triangle area is {triangle(3, 4)} m²");
            Console.WriteLine($"Triangle area is {triangle_p(3, 4, 7)} m²");
        }

        //////////////////
        static int circle(int p, int r)
        {
            p=3;
            int s = p*(r*r);
            return s;
        }

        static int rectangle(int a, int b)
        {
            return a * b;
        }

        static int triangle(int p, int r)
        {
            int s = p*r;
            return s;
        }

        static int triangle_p(int a,int b,int c)
        {
            int p = (a+b+c)/2;
            return p;
        }

    }
}
