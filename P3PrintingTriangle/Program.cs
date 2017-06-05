using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PrintingTriangle
{
    class Program
    {
        static void PrintNumbers(int start, int end)
        {
            for (int i = start ; i <= end ; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void PrintNumbersReverse(int start, int end)
        {
            for (int i = start; i >= end; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                PrintNumbers(1,i);
            }
            for (int j = (n-1); j >= 1; j--)
            {
                PrintNumbersReverse(j, 1);
            }
            
        }
    }
}
