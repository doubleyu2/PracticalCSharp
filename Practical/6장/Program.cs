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

            var array = Enumerable.Range(1, 20).ToArray();

            foreach (var x in array)
            {
                Console.WriteLine(x);
            }




        }
    }
}
