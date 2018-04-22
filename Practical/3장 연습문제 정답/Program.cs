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

            // 문제 3.1.4 SELECT 로 값 2배 만들고 List<int> 에 저장. 출력

            List<int> doubleNum = numbers.Select(i => i * 2).ToList();
            doubleNum.ForEach(i => Console.WriteLine(i));


            // 문제 3.2.1
            var name = new List<string>
            {
                "Seoul", "New Delhi","Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            string input = Console.ReadLine();
            int foundIndex = name.FindIndex(s => s == input);

            if (foundIndex >= 0)
            {
                Console.WriteLine($"{input} 은 {foundIndex + 1}번째에 저장되어 있습니다.");
            }
            else
            {
                Console.WriteLine("같은 이름의 도시를 찾을 수 없습니다.");
            }

            Console.WriteLine("계속하려면 아무키나 눌러주세요");
            // 문제 3.2.2 "o" 가 몇개있는지 세고 결과를 출력
            Console.WriteLine($"문제3.2.2: {name.Count(s => s.Contains("o"))}");

        }
    }
}
