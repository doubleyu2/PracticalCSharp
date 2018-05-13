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

            var result = numbers.Max();

            Console.WriteLine($"Max: {result}");

            Console.WriteLine();

            var temp = numbers.Length - 2; 
            var result2 = numbers.Skip(temp).ToList();
            result2.ForEach(i => Console.WriteLine(i));

            Console.WriteLine();

            var result3 = numbers.Select(i => i.ToString()).ToList();

            result3.ForEach(s => Console.WriteLine(s));

        

        }
    }

  


}
