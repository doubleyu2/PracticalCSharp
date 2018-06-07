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

            var texts = new[] {
               "Time is money.",
               "What time is it?",
               "It will take time.",
               "We reorganized the timetable.",
            };

            var pattern = @"\btime\b";

            foreach (var text in texts)
            {
                var matched = Regex.Matches(text, pattern, RegexOptions.IgnoreCase)
                                    .Cast<Match>();
                foreach (var item in matched)
                {
                    Console.WriteLine($"{item.Value},{item.Index}");
                }
                    

            }

        }

     
    }
}
