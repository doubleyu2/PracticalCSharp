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

            if (str.Contains("Str"))
            {

            }


            int idx = str.IndexOf("stu", StringComparison.CurrentCultureIgnoreCase);

            Console.WriteLine(idx);

            if (idx >= 0)
            {

            }
        }
    }
}
