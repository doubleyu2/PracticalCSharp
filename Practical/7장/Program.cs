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
            var lines = File.ReadAllLines("sample.txt");
            var we = new WordExtractor(lines);
            foreach (var word in we.Extract())
            {
                Console.WriteLine(word);
            }

           

        }
    }

    class WordExtractor
    {
        private string[] _lines;

        public WordExtractor(string[] lines)
        {
            _lines = lines;
        }

        private char[] _separators = @" !?"",.".ToCharArray();

        public IEnumerable<string> Extract()
        {
            var hash = new HashSet<string>(); // 2000번지
            foreach (var line in _lines)
            {
                var words = GetWords(line);
                foreach (var word in words)
                {
                    if (word.Length >= 10)
                        hash.Add(word.ToLower());
                    
                }
            }

            return hash.OrderBy(s => s);

        }

        private IEnumerable<string> GetWords(string line)
        {
            var items = line.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in items)
            {
                var index = item.IndexOf("'");
                var word = index <= 0 ? item : item.Substring(0, index);

                if (word.ToLower().All(c => 'a' <= c && c <= 'z'))
                    yield return word;
            }
        }

    }


}
