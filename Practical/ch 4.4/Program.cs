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

        // 읽기 전용. set이 없으면 생성자에서 지정이 가능하다. 또는 직접 초기화
        public string Name { get; } = "aaa";

        public Sale()     // 생성자 method
        {
            Length = 5;
            Name = "홍길동";
        }
    
        
    }
}
