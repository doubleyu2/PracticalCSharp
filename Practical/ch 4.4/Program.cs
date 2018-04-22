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
            
            Sale sale = null;
            //sale이 null이면 Print 메서드 실행하지 마라는 뜻
            sale?.Print();

            if (sale != null)
            {
                sale.Print();
            };


        }



    }

    class Sale
    {
        public void Print()
        {
            Console.WriteLine("안녕하세요");
        }
    }
}
