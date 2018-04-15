using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "Seoul", "New Delhi", "bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };


            // 3.3.2 Find 메서드

            string name = list.Find(s => s.Length == 6);
            Console.WriteLine(name);

            string answer = Find(list, s => s.Length == 6);
            Console.WriteLine(answer);
            


        }


        public static string Find(List<string> list, Predicate<string> judge)
        {
            string result = string.Empty;

            foreach (var item in list)
            {
                if (judge(item))
                {
                    result = item;
                    break;
                }

            }


            return result;

        }
    }
}
