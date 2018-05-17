using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5장_연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            YearMonth test = new YearMonth();
            Console.WriteLine(test.Month);
        }
    }

    class YearMonth
    {
        public int Year { get; private set; }
        public int Month { get; private set; }
        public bool Is21Century { get; set; }

        YearMonth yearmonth = new YearMonth
        {
            Year = 2018,
            Month = 05,
            Is21Century = true
        };

        public YearMonth AddOneMonth()
        {
            YearMonth newyearmonth = new YearMonth();
            newyearmonth.Month = yearmonth.Month + 1;          

            return newyearmonth;
        }
    }
}
