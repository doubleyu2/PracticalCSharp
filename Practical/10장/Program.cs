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
            var text = "Word\nExcel\nPowerpoint\nOutlook\nOneNote\n";
            var pattern = @"^[a-zA-Z]{5,7}$";
            var matches = Regex.Matches(text, pattern, RegexOptions.Multiline);
            foreach (Match m in matches)
            {
                Console.WriteLine("{0} {1}",m.Index, m.Value);
            }


        }
    }
}
