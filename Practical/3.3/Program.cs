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


            var exists = list.Exists(s => s[0] == 'A');
            Console.WriteLine(exists);

            var exists2 = Exists(list, s => s[0] == 'P');
            Console.WriteLine(exists2);



        }

        public static bool Exists(List<string> list, Predicate<string> predicate)
        {
            bool hasItem = false;
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    hasItem = true;
                    break;
                }
                   
            }
            return hasItem;
        }

            
        
    }
}
