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
            var text = "kor, KOR, Kor";

            var mc = Regex.Matches(text, @"\bkor\b", RegexOptions.IgnoreCase);
            foreach (Match m in mc)
            {
                Console.WriteLine(m.Value);
            }


        }
    }
}
