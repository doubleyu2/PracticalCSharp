using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7장_연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = "Cozy lummox gives smart squid who asks for job pen";

            /*           var alphabetcount = new Dictionary<char, int>();

                       foreach (var item in line)
                       {
                           var temp = char.ToUpper(item);
                           if ('A' <= temp && temp <= 'Z')
                           {
                               if (alphabetcount.ContainsKey(temp))
                                   alphabetcount[temp]++;
                               else
                                   alphabetcount[temp] = 1;
                           }
                       }

                       foreach (var item in alphabetcount.OrderBy(x => x.Key)) 
                       {
                           Console.WriteLine($"{item.Key} : {item.Value}");
                       }
           */

            var neworder = new SortedDictionary<char, int>();

            foreach (var item in line)
            {
                var temp = char.ToUpper(item);
                if ('A' <= temp && temp <= 'Z')
                {
                    if (neworder.ContainsKey(temp))
                        neworder[temp]++;
                    else
                        neworder[temp] = 1;
                }
            }

            foreach (var item in neworder)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
