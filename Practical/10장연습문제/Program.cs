using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace _10장연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            var textlines = File.ReadLines("sample.txt");

            //version="v4.0"
            foreach (var item in textlines)
            {
                var pattern = @"version[ ]*=[ ]*""v4\.0";

                string replace =Regex.Replace(item, pattern, @"version=""v5.0", RegexOptions.IgnoreCase);

                Console.WriteLine(replace);
            }
        

        }

     
    }
}
