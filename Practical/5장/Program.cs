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
            string str = "1414q1356";

            bool all = str.All(c => char.IsDigit(c));
            Console.WriteLine(all);

            bool result = false;

            foreach (var item in str)
            {
                if (char.IsDigit(item) == false)
                {
                    result = false;
                    break;
                }

                result = true;
            }
        }
    }
}
