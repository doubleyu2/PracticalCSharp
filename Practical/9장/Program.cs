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

            var filePath = @"c:\Example\Greeting.txt";

            Stopwatch sw = new Stopwatch();
            sw.Start();
            var lines = File.ReadLines(filePath, Encoding.UTF8).Take(3).ToList();
            lines.ForEach(s => Console.WriteLine(s));
           
            sw.Stop();

            double seconds = sw.Elapsed.TotalSeconds;

            Console.WriteLine(seconds);
        }
    }
}
