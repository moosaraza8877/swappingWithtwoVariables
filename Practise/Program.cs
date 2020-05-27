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
            int a, b;
            Console.Write("Enter first value: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----- Before swapping -----");
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("----- After swapping -----");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
