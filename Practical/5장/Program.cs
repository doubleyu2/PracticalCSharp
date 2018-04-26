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
            StringBuilder sb = new StringBuilder();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            var s1 = "ABC";

            for (int i = 0; i < 10000000; i++)
            {
                // s1 += "A";
                sb.Append("A");
            }

            sw.Stop();

            double seconds = sw.Elapsed.TotalSeconds;
            Console.WriteLine(sb.ToString());
            Console.WriteLine(seconds);

        }
    }
}
