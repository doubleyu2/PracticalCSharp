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
            var text = "Word, Excel ,Powerpoint ,            Outlook,OneNote";
            var pattern = @"\s*,\s*";
            var replaced = Regex.Replace(text, pattern, ", ");
            Console.WriteLine(replaced);

        }
    }
}
