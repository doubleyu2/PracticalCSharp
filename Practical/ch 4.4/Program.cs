using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;

            Console.WriteLine($"{a},{b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"{a},{b}");

        }

    }
    
}
