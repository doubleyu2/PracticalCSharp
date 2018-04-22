using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습문제_3장
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 문제 3.1.1
            var existNumber = numbers.Exists(i => (i % 8 == 0 || i % 9 == 0));

            Console.WriteLine($"문제 3.1.1: {existNumber}");

            // 문제 3.1.2
            numbers.ForEach(i => Console.WriteLine($"문제 3.1.2: {i % 2}"));

            // 문제 3.1.3 값이 50이상 
            var foundNum = numbers.Where(i => i >= 50);   /// foundNum 에서 ForEach method 안되는 이유 찾기

            foreach (var item in foundNum)
            {
                Console.WriteLine($"문제 3.1.3: {item}");
            }

            //문제 3.1.4  List<int> 에 IEnumerable 할당 방법
           /* List<int> doubleNum = numbers.Where(i => i != 0).Select(i => i * 2));   
            * 

            Console.WriteLine("문제 3.1.4");
            foreach (var item in doubleNum)
            {
                Console.WriteLine(item);
            } */


            // 문제 3.2.1

            var names = new List<string>
            {
                "Seoul", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            Console.WriteLine("문제 3.2.1: 도시명을 입력하세요");
            var line = Console.ReadLine();
            int foundIndex = names.FindIndex(s => s == line);

            if (foundIndex >= 0)
            {
                Console.WriteLine($"{line} 은 {foundIndex + 1}번째에 저장되어 있습니다");
            }
            else
            {
                Console.WriteLine("일치하는 도시명이 없습니다. 대소문자 구분합니다");
            }

            // 문제 3.2.2 

            numbers.Count(s => s.
        }
        


    }

}
