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
            // 인간의 사고방식과 비슷하게
            // if(age <= 10)

            // if(10 >= age)  이렇게 하면 안된다.


            // 직관적으로 이해하기 쉽게 표현한다. (min <= num <= max)
            // if (MinValue <= num && num <= MaxValue) 


            // else-if 를 통한 다분기 처리  if 를 중첩시키지 않고  else-if 로 처리한다.
            
           
        }

        //4.2.4 체로 걸러 남은 것만을 처리한다.
        public static bool SkipTest(int n)
        {
            if (n % 5 == 0)
            {
                return false;
            }
            
            if (n % 12 == 0)
            {
                return false;
            }

            return true;
        }
    }
}
