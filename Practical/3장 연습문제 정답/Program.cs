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

            // 문제 3.2.4 B로 시작하는 도시이름의 문자개수 출력

            var foundCity = name.Where(s => s.StartsWith("B")).Select(s => new Pair { Name = s, Length = s.Length }).ToList();
            var foundCity2 = name.Where(s => s.StartsWith("B")).ToDictionary(s => s, s => s.Length);

            

            foundCity.ForEach(p => Console.WriteLine($"이름: {p.Name}, 길이: {p.Length}"));


            foreach (var item in foundCity2)
            {
                Console.WriteLine($"이름: {item.Key}, 길이: {item.Value}");
            }


        }
    }

    class Pair
    {
        public string Name { get; set; }
        public int Length { get; set; }
    }
}
