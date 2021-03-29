using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[100, 100];
            int i, j, left = 0, right = 0, diff = 0, n;
            Console.WriteLine("Decleare array size: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array elements: ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        left = left + a[i, j];
                    }
                    if (i == (n - j - 1))
                    {
                        right = right + a[i, j];
                    }
                }
            }
            diff = Math.Abs(left - right);
            Console.WriteLine("The digonal difference: ");
            Console.WriteLine(diff);
            Console.ReadLine();
        }
    }
}
