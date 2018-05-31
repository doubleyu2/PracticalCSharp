using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10장
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "private List<string> results = new List<string>();";
            var matches = Regex.Matches(text, @"\b[a-z]+\b")
                                .Cast<Match>()
                                .OrderBy(x => x.Length);

            foreach (Match match in matches)
            {
                Console.WriteLine("Index = {0}, Length = {1}, Value = {2}", match.Index, match.Length, match.Value);
            }



        }
    }
}
