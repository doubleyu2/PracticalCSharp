using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3장_연습문제_정답
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new List<string>
            {
                "Seoul", "New Delhi","Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

          //  string input = Console.ReadLine();


            // 문제 3.2.3 
            string[] foundNames = name.Where(s => s.Contains("o")).ToArray();

            foreach (var item in foundNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
