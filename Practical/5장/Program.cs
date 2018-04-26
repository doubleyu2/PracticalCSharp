using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5장
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Novelist=김만중;BestWork=구운몽;Born=1687";
            string find = "BestWork=";
            var startIndex = str.IndexOf(find) + find.Length;
            var endIndex = str.IndexOf(";", startIndex); 
            string bestwork = str.Substring(startIndex, endIndex - startIndex);

            Console.WriteLine(bestwork);
            


        }
    }
}
