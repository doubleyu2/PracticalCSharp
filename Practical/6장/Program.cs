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

            var numbers = Enumerable.Repeat(-1, 20).ToList();

            numbers.ForEach(x => Console.WriteLine(x));



        }
    }
}
