using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int intInput = int.Parse(input);

            bool result = intInput % 5 == 0 ? true : false;
            Console.WriteLine(result);
        }
    }
}
