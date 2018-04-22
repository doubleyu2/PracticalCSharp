using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch_4._4
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string txt = File.ReadAllText("a.txt");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("파일이 없습니다.");
            }

        }

    }
    
}
