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
                ["pansy"] = 300
            };

            var average = flowerDict.Average(x => x.Value);
            Console.WriteLine(average);




        }
    }
}
