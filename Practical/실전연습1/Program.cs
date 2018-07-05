using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace 실전연습1
{
    class Program
    {

        static void Main(string[] args)
        {

            var sw = new Stopwatch();
            sw.Start();


            while (true)
            {
                // 1 분 경과후 실행 

                if (sw.Elapsed.TotalSeconds <= 5)
                {
                    //프로그램 대기
                    continue;

                }

                Console.Clear();
                var wc = new WebClient
                {
                    Encoding = Encoding.UTF8
                };
                var src = wc.DownloadString("http://naver.com");

                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(src);

                var nodes = doc.DocumentNode.SelectNodes("//div[@class='ah_roll PM_CL_realtimeKeyword_rolling_base']//li[@class='ah_item']");

                
                var kdl = new List<Keyword>();


                foreach (var node in nodes)
                {
                    var keyword = new Keyword
                    {
                        Ranking = int.Parse(node.SelectSingleNode(".//span[@class='ah_r']").InnerText),
                        Title = node.SelectSingleNode(".//span[@class='ah_k']").InnerText
                    };

                    if (KeywordManager.HasKeyword(keyword) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(keyword);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(keyword);
                    }

                    kdl.Add(keyword);

                }

                KeywordManager.Clear();
                foreach (var item in kdl)
                {
                    KeywordManager.Add(item);
                }

                sw.Restart();
            }




            /*

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
                                var keywordn = Regex.Split(keywordtitle, @"</span>")[0];

                                var keyword = new Keyword { Ranking = int.Parse(ranking), Title = keywordn };

                                // 키워드 있나? 
                                if (KeywordManager.HasKeyword(keyword) == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(keyword);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.WriteLine(keyword);
                                }
                                // 키워드 매니저 Add
                                kwdList.Add(keyword);

                            }

                            KeywordManager.Clear();
                            foreach (var item in kwdList)
                            {
                                KeywordManager.Add(item);
                            }

                            sw.Restart();
                        }           */

        }
    }

    public class Keyword
    {
        public int Ranking { get; set; }
        public string Title { get; set; }

        public override bool Equals(object obj)         // KeywordManager 에서 Contains 를 사용하려면 Keyword class 에서 Equals 를 갖고 있어야 함. 
        {
            var keyword = obj as Keyword;               // type 변환(AS)은 parent-child 관계에서만. 형변환 실패하면 null 값 들어감.  
            return keyword != null &&                   // null 상태에서 비교하면 에러 발생. 먼저 null인지 확인. Equals 에 다른 class 뭐든지 올 수 있음 (변수가 object). 
                   Ranking == keyword.Ranking &&
                   Title == keyword.Title;
        }

        public override int GetHashCode()
        {
            var hashCode = -1112502526;
            hashCode = hashCode * -1521134295 + Ranking.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            return hashCode;
        }

        public override string ToString()
        {
            return $"ranking:{Ranking},Title:{Title}";
        }
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

        public static void Clear()
        {
            keywordList.Clear();
        }
        public static void Print()
        {
            foreach (var item in keywordList)
            {
                Console.WriteLine($"{item.Ranking}. {item.Title}");
            }
        }

        public static bool HasKeyword(Keyword keyword)
        {
            return keywordList.Contains(keyword);
        }

    }
}


