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
            var text = "기러기 펠리컨 청둥오리 오리너구리 토마토 pops push pop";
            var pattern = @"\b(\w)\w\1\b";
            var matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine("'{0}'",item.Value);
            }
        }
    }
}
