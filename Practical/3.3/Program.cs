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


            // 3.4.4

            // where 메서드만 쓰면 지연실행 상태가 됨.
            // ToList나 ToArray 같이 바꿔주는 메서드를 실행하면 즉시 결과가 저장됨.
            //IEnumerable<string> answer = list.Where(s => s.Length <= 5
            IEnumerable<string> answer = list.Where(s => s.Length <= 5).ToList();


            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }

            list[0] = "Busan";

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }

            list[0] = "Busap";

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }


            var count = list.Count(s => s.Length <= 5);
            Console.WriteLine(count);



        }



    }
}
