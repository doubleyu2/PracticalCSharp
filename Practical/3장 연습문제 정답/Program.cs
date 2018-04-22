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
            var numbers = new List<int>
            {
                12, 87, 94,14,53,20,40,35,76,91,31,17,48
            };

            // 문제 3.1.1

            if (numbers.Exists(i => i % 8 == 0 || i % 9 == 0))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            // 문제 3.1.2 

            Console.WriteLine("문제 3.1.2");
            numbers.ForEach(i => Console.WriteLine(i % 2));

            // 문제 3.1.3 LINQ WHERE >= 50
            var over50List = numbers.Where(i => i >= 50);
            foreach (var item in over50List)
            {
                Console.WriteLine(item);
            }
        }
    }
}
