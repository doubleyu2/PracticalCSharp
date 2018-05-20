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
            var dt1 = new DateTime(2017, 10, 22);
            var dt2 = new DateTime(2017, 10, 22, 8, 45, 20);
            var today = DateTime.Today;
            var now = DateTime.Now;

            Console.WriteLine($"Today:{today}");
            Console.WriteLine($"Now:{now}");

            DayOfWeek dayOfWeek = today.DayOfWeek;
            if(dayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine("일요일");


        

        }
    }
}
