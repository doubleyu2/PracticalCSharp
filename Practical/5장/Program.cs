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

            bool has = str.Any(c => c == 'i');
            bool hastoOf = false;

            foreach (var item in str)
            {
                if(item == 'i')
                {
                    hastoOf = true;
                    break;
                }  
            }

            Console.WriteLine(has);
            Console.WriteLine(hastoOf);
        }
    }
}
