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

            //Predicate -> 반환 타입이 bool인 delegate
            //Action -> 반환 타입이 void인 delegate
            list.ForEach(s => Console.WriteLine(s));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
        
        
        
    }
}
