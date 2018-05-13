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
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            var result = numbers.OrderBy(i => i).Take(3).ToList();

            result.ForEach(i => Console.WriteLine(i));

            var result2 = numbers.Distinct().Where(i => i > 10).Count();

            Console.WriteLine();
            Console.WriteLine(result2);


        

        }
    }

  


}
