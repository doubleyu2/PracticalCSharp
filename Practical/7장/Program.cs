using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7장
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> flowerDict = new Dictionary<string, int>
            {
                ["sunflower"] = 400,
                ["pansy"] = 300,
                ["tulip"] = 200,
                ["rose"] = 500,
                ["dahlia"] = 400,
            };


            var dict = flowerDict.Where(p => p.Value >= 400).ToDictionary(p => p.Key, p => p.Value);
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

        }
    }

    class Employee
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
