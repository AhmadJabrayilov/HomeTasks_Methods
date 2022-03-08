using System;

namespace divide_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("input num2: ");
            int num2 = int .Parse(Console.ReadLine());
            Console.WriteLine("Result: " + divide(num1,num2));

            //Console.WriteLine($"Result: {divide(20, 4)}");
        }
        private static int divide(int num1, int num2)
        {
            
            return num1/num2;
        }
    }
}
