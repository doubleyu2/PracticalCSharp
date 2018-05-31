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
            var text = "1234567890123456";
            var pattern = @"(\d{4})(\d{4})(\d{4})(\d{4})";
            var replaced = Regex.Replace(text, pattern, "$1-$2-$3-$4");
            Console.WriteLine(replaced);

        }
    }
}
