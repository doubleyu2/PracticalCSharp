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

            var date = DateTime.Now;

            string s1 = date.ToString("yyyy-MM-dd");
            int m = date.Month;

            Console.WriteLine(s1);
            
        }
    }
}
