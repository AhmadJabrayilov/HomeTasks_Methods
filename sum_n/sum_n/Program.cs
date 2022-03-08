using System;

namespace sum_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 15, 20, 10, 26, 12, 32 };
            int sum = all(nums);
            Console.WriteLine(sum);


        }

        static int all(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
