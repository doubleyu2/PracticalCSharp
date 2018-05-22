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
            //   1
            //   2
            //  10
            // 100
            //9999
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var lines = File.ReadLines(filePath, Encoding.UTF8)
                            .Select((s, ix) => String.Format("{0,4}:{1}", ix + 1, s))
                            .ToList();

            lines.ForEach(s => Console.WriteLine(s));
            sw.Stop();

            double seconds = sw.Elapsed.TotalSeconds;

            Console.WriteLine(seconds);
        }
    }
}
