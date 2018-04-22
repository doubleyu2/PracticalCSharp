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

        }



    }

    class Sale
    {
        // 프로퍼티 초기값 생성자를 거치지 않아도 됨
        public int Length { get; set; } = 5;

        public Sale()
        {
            Length = 5;
        }
    }
}
