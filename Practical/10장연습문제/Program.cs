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
            var textlines = File.ReadLines("sample.html");

            foreach (var item in textlines)
            {
                string replace = Regex.Replace(item, @"<(/?)([A-Z][A-Z0-9]*)([^>]*)>", m =>
                {
                    return string.Format("<{0}{1}{2}>", m.Groups[1].Value, m.Groups[2].Value.ToLower(), m.Groups[3].Value);

                });

                Console.WriteLine(replace);



            }
        

        }

     
    }
}
