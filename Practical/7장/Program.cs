using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7장
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

            // 인덱서를 사용한 예
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names)
            {
                var fullname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}을(를) 찾을 수 없습니다.", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();

            // ToAbbreviation 메서드를 이용한 예
            var japanese = "동남아시아 국가 연합";
            var abbreviation = abbrs.ToAbbreviation(japanese);
            if (abbreviation == null)
                Console.WriteLine("{0}을(를) 찾을 수 없습니다.", japanese);
            else
                Console.WriteLine("「{0}」의 줄임말은 {1}입니다.", japanese, abbreviation);
            Console.WriteLine();

            // FindAll 메서드를 이용한 예
            foreach (var item in abbrs.FindAll("국제"))
            {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();


        }
    }


    class Abbreviations
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


    }
