using System;


namespace P2SignOfInteger
{
    class Program
    {
        static void PrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The number {0} is positive.", num);
            }
            else if (num < 0 )
            {
                Console.WriteLine("The number {0} is negative.", num);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", num);
            }
        }
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
