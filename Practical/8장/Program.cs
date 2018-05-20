using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8장
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12b345";
            int a;

            if(int.TryParse(s, out a))
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("변환 실패");
            }
            DateTime dt1;
            if(DateTime.TryParse("2017/6/21", out dt1))
                Console.WriteLine(dt1);
            DateTime dt2;
            if(DateTime.TryParse("2017/6/21 10:41:38", out dt2))
                Console.WriteLine(dt2);

            int x = 3;
            Test(out x);
            Console.WriteLine(x);

        }
        static void Test(out int a)
        {
            a = 5;

        }
    }
}
