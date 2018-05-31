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
            var text = "<person><name>김삿갓</name><age>22</age></person>";
            var pattern = @"<(\w[^>]+)>";
            var matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
            {
                Console.WriteLine("'{0}'",m.Groups[1].Value);
            }

        }
    }
}
