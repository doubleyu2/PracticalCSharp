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
        // 읽기 전용. 클래스 내부에서만 접근 가능
        public int Length { get; private set; } = 5;

        // 읽기 전용. 고정
        public string Name => "홍길동";

        public Sale()     // 생성자 method
        {
            Length = 5;
           
        }
    
        
    }
}
