using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 실전연습1
{
    class Program
    {
 
        static void Main(string[] args)
        {
            
            var wc = new WebClient
            {
                Encoding = Encoding.UTF8
            };
           var src = wc.DownloadString("http://naver.com");
           

//            Console.WriteLine(src);

           var splited1 = Regex.Split(src, @"<h3 class=""blind"">실시간 급상승 검색어</h3>");

           var splited2 = Regex.Split(splited1[1], @"<span class=""ah_ico_open""></span>");

            var area = splited2[0];

            var keywordlist = Regex.Split(area, @"<li class=""ah_item"">");

            foreach (var item in keywordlist.Skip(1))
            {
                
                // 순위
               var tempkeyword = Regex.Split(item, @"<span class=""ah_r"">")[1];
               var ranking = Regex.Split(tempkeyword, @"</span>")[0];

                // 키워드 이름
                var keywordtitle = Regex.Split(item, @"<span class=""ah_k"">")[1];
                var keyword = Regex.Split(keywordtitle, @"</span>")[0];

                // 키워드 매니저 Add
                KeywordManager.Add(new Keyword { Ranking = int.Parse(ranking), Title = keyword });
//                km.Add(new Keyword { Ranking = int.Parse(ranking), Title = keyword });


            }


            // 키워드 매니저 출력

            KeywordManager.Print();
            
        }
    }

    public class Keyword
    {
        public int Ranking { get; set; }
        public string Title { get; set; }
    }

    public static class KeywordManager
    {
        private static List<Keyword> keywordList;

        static KeywordManager()             // 생성자 method. class 이름과 같게. 반환타입 안적어도 됨-생성자 method 의 경우에만.
        {
            keywordList = new List<Keyword>();
        }

        public static void Add(Keyword keyword)
        {
            keywordList.Add(keyword);
        }

        public static void Print()
        {
            foreach (var item in keywordList)
            {
                Console.WriteLine($"{item.Ranking}. {item.Title}");
            }
        }

    }
}
