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

            var dt1 = new DateTime(2006, 10, 18, 1, 30, 21);
            var dt2 = new DateTime(2006, 11, 2, 18, 5, 28);
            if (dt1 < dt2)
                Console.WriteLine("dt2 이 미래");
            else if (dt1 == dt2)
                Console.WriteLine("같은 시각입니다");


            var diff = dt2 - dt1;

            double total = diff.TotalSeconds;

            Console.WriteLine(total);
             


            var today = DateTime.Now;

            var future = today.AddSeconds(5);

            while(true)
            {
                today = DateTime.Now;
                var fd = future - today;

                if (fd.TotalSeconds <= 0)
                {
                    Console.WriteLine("끝");
                    break;
                }
            }
        }
    }
}
