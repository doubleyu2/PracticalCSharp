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
             
            var tempFileName = Path.GetTempFileName();

            var fileName = Path.GetFileName(tempFileName);
            Console.WriteLine(tempFileName);
            Console.WriteLine(fileName);

        }
    }
}
