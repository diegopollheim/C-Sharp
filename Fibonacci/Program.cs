using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;

            for(int i = 0; i < 7; i++)
            {
                Console.Write($" {n1}");
                Console.ReadKey();
                Console.Write($" {n2}");
                n1 = n2 + n1;
                n2 = n1 + n2;
                Console.ReadKey();
            }
        }
    }
}
