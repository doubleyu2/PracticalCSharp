using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int> { 1, 2, 3, 4, 5 };
            nums.ForEach(n => Console.WriteLine(n));

        }
    }
}
