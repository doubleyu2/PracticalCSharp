using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5장_연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문제 5.1 

            Console.WriteLine("첫번째 문자열을 입력하세요");
            string str1 = Console.ReadLine();

            Console.WriteLine("두번째 문자열을 입력하세요");
            string str2 = Console.ReadLine();

            if (str1 != str2)
            {
                Console.WriteLine("두개의 문자열이 상이합니다");
            }
            else
            {
                Console.WriteLine("두개의 문자열이 동일합니다");
            }

            // 문제 5.2 

        }
    }
}
