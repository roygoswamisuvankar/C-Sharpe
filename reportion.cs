/*roportion of positive values
proportion of negative values
proportion of zeros
*/
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
            int[] a = new int[100];
            int n, i;
            float pos = 0, neg = 0, count = 0;
            Console.WriteLine("Enter array size: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    pos++;
                    
                }
                if (a[i]<0)
                {
                    neg++;
                    
                }
                if (a[i] == 0)
                {
                    count++;
                    
                }
            }
            Console.WriteLine( pos / n);    //n : size of the list
            Console.WriteLine(neg / n);
            Console.WriteLine(count / n);
            Console.ReadLine();
        }
    }
}

