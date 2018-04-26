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
            string str = "Visual Studio";

            if (str.StartsWith("visual", StringComparison.CurrentCultureIgnoreCase))
            { 
                Console.WriteLine("시작합니다.");
            }
        }
    }
}
