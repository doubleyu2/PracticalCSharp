using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_초기화와_관련된_관용구
{
    class Program
    {
        static void Main(string[] args)
        {
            // 변수 선언과 초기화를 한줄에 한다. 선언과 초기화를 분리하면 중간에 코드가 낄 수 있으므로 나쁜 예.
            
            int age = 25;

            /*
             * int age;
             * age = 25;
             */


            // 4.1.2 배열과 리스트 초기화
            {
                var langs = new string[] { "C#", "VB", "C++", };
                var nums = new List<int> { 10, 20, 30, 40, };
            }

            {
                string[] langs = new string[4];
                langs[0] = "C#";
                langs[1] = "VB";
                langs[2] = "F#";
                langs[3] = "C++";
            }
            {
                List<int> nums = new List<int>();
                nums.Add(10);
                nums.Add(20);
                nums.Add(30);
                nums.Add(40);
            }

            // 4.1.3 Dictionary 초기화 

            {
                var dict = new Dictionary<string, string>
                {
                    { "ko", "한국어" },
                    { "en", "영어"},
                    {"es", "스페인어" },
                    {"de", "독일어"},

                };
            }
            {
                var dict = new Dictionary<string, string>()
                {
                    ["ko"] = "한국어",
                    ["en"] = "영어",
                    ["es"] = "스페인어",
                    ["de"] = "독일어",
                };

                dict["k"] = "한국";

            }

            //  4.1.4 객체 초기화 

            Person person = new Person
            {
                Name = "홍길동",
                Birthday = new DateTime(1995, 11, 23),
                PhoneNumber = "010-3567-4556"
            };


        }
    }

    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
    }
}
