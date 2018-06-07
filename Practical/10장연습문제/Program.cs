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
            var text = "기러기 국제경제국 다들잠들다 너구리 시집간집시 토마토 건조할조건";

            var pattern = @"\b(\w)(\w)\w\2\1\b";

            var matchs = Regex.Matches(text, pattern).Cast<Match>();

            foreach (var item in matchs)
            {
                Console.WriteLine(item.Value);
            }



        }

     
    }
}
