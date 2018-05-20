using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7장_연습문제_정답
{
    class Program
    {
        static void Main(string[] args)
        {
            // 생성자를 호출한다
            var abbrs = new Abbreviations();

            // Add 메서드를 호출한 예
            abbrs.Add("IOC", "국제 올림픽 위원회");
            abbrs.Add("NPT", "핵확산방지조약");

            // 7.2.1 Count
            Console.WriteLine();
            var count = abbrs.Count;
            Console.WriteLine(count);

            // 7.2.2 Remove
            var test = abbrs.Remove("IOC");
            Console.WriteLine("Remove 확인");
            Console.WriteLine(test);
            Console.WriteLine(abbrs.Count);

            // 7.2.4 
            var result = abbrs.Where(s => s.Key.Length == 3);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }


        }
    }


    class Abbreviations : IEnumerable<KeyValuePair<string, string>>
    {
        private Dictionary<string, string> _dict;

        // 생성자
        public Abbreviations()
        {
            _dict = new Dictionary<string, string>();
            var lines = File.ReadAllLines("Abbreviations.txt");
            _dict = lines.Select(line => line.Split('='))
                         .ToDictionary(x => x[0], x => x[1]);
        }

        // 요소를 추가한다
        public void Add(string abbr, string japanese)
        {
            _dict[abbr] = japanese;
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
        public string ToAbbreviation(string japanese)
        {
            return _dict.FirstOrDefault(x => x.Value == japanese).Key;
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

        public int Count        
        {
            get { return _dict.Count; }
        }

        public bool Remove(string _abbr)
        {
            return _dict.Remove(_abbr);
        }

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
