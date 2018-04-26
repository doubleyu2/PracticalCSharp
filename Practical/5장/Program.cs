using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5장
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            var s1 = number.ToString();
            var s2 = number.ToString("#,#.0");

            Console.WriteLine(s2);
           

        }
    }
}
