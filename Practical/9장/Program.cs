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
            
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                using (var reader = new StreamReader(stream))
                using (var writer = new StreamWriter(stream))
                {
                    string texts = reader.ReadToEnd();
                    stream.Position = 0;
                    writer.WriteLine("삽입할 새 행1");
                    writer.WriteLine("삽입할 새 행2");
                    writer.Write(texts);
                }
            }`
        }
    }
}
