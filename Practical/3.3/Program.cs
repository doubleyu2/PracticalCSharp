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


            int index = list.FindIndex(s => s == "Paris");
            Console.WriteLine(index);


            int index2 = FindIndex(list, s => s == "Paris");
            Console.WriteLine(index2);

        }
        

        public static int FindIndex(List<string> list, Predicate<string> predicate)
        {
            int index2 = -1;  // null 대신

            for(int i = 0; i < list.Count; i++)
            {
                if (predicate(list[i]))
                {
                    index2 = i;
                    break;
                }
            }
            return index2;
        }
            
        
    }
}
