using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count = 1;
            Console.Write("Enter number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());
            count = n - 1;
            for(int k = 1; k <= n; k++)
            {
                for(int i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;
                for (int i = 1; i <= 2 * k - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            count = 1;
            for(int k = 1; k <= n - 1; k++)
            {
                for(int i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count++;
                for (int i = 1; i <= 2 * (n - k) - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
