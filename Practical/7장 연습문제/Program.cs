using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Collections;

namespace _7장_연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            var abbrs = new Abbreviations();

            abbrs.Add("IOC", "국제 올림픽 위원회");
            abbrs.Add("NPT", "핵확산방지조약");

            var count = abbrs.Count;
            Console.WriteLine("7.2.3-1");
            Console.WriteLine(count);

            Console.WriteLine("7.2.3-2");
            if (abbrs.Remove("NPT"))
                Console.WriteLine(count);
            if (!abbrs.Remove("NPT"))
                Console.WriteLine("삭제할 수 없습니다.");

            Console.WriteLine();

            foreach (var item in abbrs.Where(x => x.Key.Length ==3))
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
           



        }
    }


    class Abbreviations : IEnumerable<KeyValuePair<string, string>>  
    {

        private Dictionary<string, string> _dict = new Dictionary<string, string>();

        // 생성자
        public Abbreviations()
        {
            var lines = File.ReadAllLines("Abbreviations.txt");
            
            _dict = lines.Select(line => line.Split('='))
                         .ToDictionary(x => x[0], x => x[1]);
        }

        // 요소를 추가한다
        public void Add(string abbr, string korean)
        {
            _dict[abbr] = korean;
        }

        // 인덱서: 줄임말을 키로 사용한다
        public string this[string abbr]
        {
            get
            {
                return _dict.ContainsKey(abbr) ? _dict[abbr] : null;
            }
        }

        // 한국어로부터 그에 대응되는 줄임말을 구한다
        public string ToAbbreviation(string korean)
        {
            return _dict.FirstOrDefault(x => x.Value == korean).Key;
        }

        // 한국어의 위치를 인수에 넘겨주고 그것이 포함되는 요소(Key,Value)를 모두 구한다
        public IEnumerable<KeyValuePair<string, string>> FindAll(string substring)
        {
            foreach (var item in _dict)
            {
                if (item.Value.Contains(substring))
                    yield return item;
            }
        }

        // 7.2.1 
        public int Count
        {
            get
            {
                return _dict.Count();
            }
        }

        public bool Remove(string abb)
        {
            return _dict.Remove(abb);
        }

        // 7.2.4
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<string, string>>)_dict).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<string, string>>)_dict).GetEnumerator();
        }
    }
}
