using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9장
{
    class Program
    {
        static void Main(string[] args)
        {

            var topdir = @"C:\Example\";
            var subdir = @"Temp";
            var fname = "Greeting.txt";
            var path = Path.Combine(topdir, subdir, fname);

            Console.WriteLine($"TopDirectory:{topdir}");
            Console.WriteLine($"Path: {path}");

        }
    }
}
