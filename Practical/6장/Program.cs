using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6장
{



    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4,1, 0, 4 };
            var average = numbers.Average();

            Console.WriteLine(average);


        }
    }
}
