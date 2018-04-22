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
            string msg = null;

            //if (msg == null)
            //{
            //    msg = "안녕";
            //}


            string message = msg ?? "널입니다.";

            Console.WriteLine(message);


        }



    }
}
