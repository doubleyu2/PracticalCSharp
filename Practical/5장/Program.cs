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
            var languages = new[] { "C#", "Java", "VB", "Ruby" };
            var separator = ", ";

            var result = String.Join(separator, languages);

            Console.WriteLine(result);
            //숫자만 출력

        }
    }
}
