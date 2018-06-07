using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10장연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var text = Console.ReadLine();
                if (text == "-1")
                {
                    break;
                }
                bool result = IsMatch(text);
                Console.WriteLine(result);
            }

            //           var matches = Regex.Matches(text, pattern);

        }
        public static bool IsMatch(string _text)
        {
            var pattern = @"(0[789]0-\d{4}-\d{4})";
            var match = Regex.Match(_text, pattern);

            string value = match.Groups[1].Value;
            Console.WriteLine(value);


            return match.Success;


        }

    }
}
