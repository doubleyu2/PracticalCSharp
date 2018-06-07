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

            
            foreach (var item in textlines)
            {
                var numbers = GetNumber(item);

                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }

               
            }
        
 

        }

        static IEnumerable<int> GetNumber(string _text)
        {
            var pattern = @"\b\d{3,}\b";

            var matches = Regex.Matches(_text, pattern)
                               .Cast<Match>();

            foreach (var match in matches)
            {
                yield return int.Parse(match.Value);

            }

            
        }
    }
}
