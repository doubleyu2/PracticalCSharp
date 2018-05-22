using System;
using System.Collections.Generic;
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

            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    while(!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
               
            }
        }
    }
}
