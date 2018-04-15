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


            List<string> query = list.Where(s => s.Length <= 5)
                                    .Select(s => $"값: {s}, P 포함여부 : {s.Contains("P")}")
                                    .ToList();

            query.ForEach(s => Console.WriteLine(s));

            


        }
        
        
        
    }
}
