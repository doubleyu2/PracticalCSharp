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


            var query = from s in list
                        where s.Length >= 5
                        select s.ToUpper();

            foreach (string s in query)
            {
                Console.WriteLine(s);
            }


            var query2 = list.Where(s => s.Length >= 5).Select(s => s.ToUpper()).ToList();

            query2.ForEach(s => Console.WriteLine(s));


        }



    }
}
