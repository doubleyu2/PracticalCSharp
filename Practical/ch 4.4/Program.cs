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
            var obj = new MySample();
            obj.MyList.Add(6);              // obj 의 MyList 에 add. Get 만을 사용 

            obj.Print();

            obj.MyList = new List<int>();

        }



    }
    
    class MySample
    {
        public IReadOnlyList<int> MyList { get; private set; }

        public MySample()
        {
            MyList = new List<int>() { 1, 2, 3, 4, 5, };
        }

        public void Print()
        {
            MyList.ForEach(i => Console.WriteLine(i));
        }
    }
}
