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
            string str = "012WERJUIJSDF34567";

            int start = -1;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    if (start == -1)
                    {
                        start = i;
                    }
                    count++;

                }
                else
                {
                    if (start != -1)
                    { 
                        break;
                    }
                }
            

            }

    


    
            var result = str.Remove(start, count);

            Console.WriteLine(result);

            //숫자만 출력

        }
    }
}
