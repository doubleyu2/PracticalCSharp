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
            Regex reg = new Regex(@"(010)[- ]?(\d{4})[- ]?(\d{4})");

            string text = "안녕하세요 01037397593";

            Match match = reg.Match(text);

            if (match.Success)
            {
                Console.WriteLine($"index: {match.Index}, Value: {match.Value}");
            }



        }
    }
}
