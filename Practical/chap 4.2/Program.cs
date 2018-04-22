using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap_4._2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool t = IsTest(3, 5);
            

        }

        public static bool IsTest(int a, int b)
        {
            /*
             * if(a==b)
             * {
             *  return true;
             * }
             * else
             * {
             * return false;
             * }
             */ 
            return a == b;
        }
   
    }
}
