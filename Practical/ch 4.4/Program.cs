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
            Print();

        }

        public static void Print(string msg="안녕하세요", int n=1)
        {
            for(int i = 1; i<= n; i++)
            {
                Console.WriteLine(msg);
            }
        }

    }
    
}
