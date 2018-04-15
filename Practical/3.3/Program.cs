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


            List<string> foundList = list.FindAll(s => s.Length >= 5);

            foreach (var item in foundList)
            {
                Console.WriteLine(item);
            }

            List<string> resultList = FindAll(list, s => s.Length >= 5);

            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }


        }

        public static List<string> FindAll(List<string> list, Predicate<string> predicate)
        {
            List<string> result = new List<string>();

            foreach (var item in list)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;

        }
        
        
        
    }
}
