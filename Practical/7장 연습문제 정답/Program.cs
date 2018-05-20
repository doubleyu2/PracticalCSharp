using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7장_연습문제_정답
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = "Cozy lummox gives smart squid who asks for job pen";
            var dict = new Dictionary<char, int>();

            foreach (var item in line)
            {
                var ch = char.ToUpper(item);

                if ('A' <= ch && ch <= 'Z')
                {
                    if (dict.ContainsKey(ch))
                    {
                        dict[ch]++;
                    }
                    //else (!dict.ContainsKey(ch))
                    else 
                    {
                        dict[ch] = 1;
                    }
                } 
            }

            foreach (var item in dict.OrderBy(p => p.Key))
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
}
