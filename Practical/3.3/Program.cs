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

            int count = list.RemoveAll(s => s.Contains("on"));
            Console.WriteLine(count);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
       

        }
        
        
        
    }
}
