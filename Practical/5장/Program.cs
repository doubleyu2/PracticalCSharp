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
            var text = "The quick brown fox jumpts over the lazy dog";

            string[] words = text.Split(' ');
            
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
