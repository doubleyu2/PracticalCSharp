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
            var text = "<p>가나다라마</p><p>바사아자차</p>";
            var pattern = @"<p>(.*?)</p>";
            var matches = Regex.Matches(text, pattern);
            foreach (Match item in matches)
            {
                Console.WriteLine("'{0}'", item.Groups[1].Value);
            }
        }
    }
}
