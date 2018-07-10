using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using System.Diagnostics;
using System.IO;
using System.Media;


namespace 실전연습2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("찾으실 단어를 입력하세요");
            var searchWord = Console.ReadLine();

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

 //               Console.Clear();

                var wc = new WebClient
                {
                    Encoding = Encoding.Default,
                   
                };

                wc.Headers.Add(HttpRequestHeader.Referer,"https://cafe.naver.com/joonggonara.cafe?iframe_url=/ArticleList.nhn%3Fsearch.clubid=10050146%26search.boardtype=L%26viewType=pc");
                wc.Headers.Add(HttpRequestHeader.Upgrade, "1");
                wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36");
                var src = wc.DownloadString("https://cafe.naver.com/ArticleList.nhn?search.clubid=10050146&search.boardtype=L&viewType=pc");
                
                //Console.WriteLine(src);
                HtmlDocument doc = new HtmlDocument();

                doc.LoadHtml(src);

               File.WriteAllText("htmlsource.html",src,Encoding.Default);

                var articleNode = doc.DocumentNode.SelectSingleNode("//form[@name='ArticleList']");

                if (articleNode==null)
                {
                    Console.WriteLine("Null");
                }

                // Console.WriteLine(articleNode.InnerHtml);

                var articles =  articleNode.SelectNodes(".//span[@class='aaa']");

                Console.Clear();

                foreach (var item in articles)
                {
                    string article = item.SelectSingleNode("./a").InnerText;  // 태그 묶인 안에 있는 텍스트
                    
                    if (article.Contains(searchWord)==true)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(article);
                        Console.ResetColor();
                        SoundPlayer sp = new SoundPlayer("");
                        sp.Play();
                    }
                    else Console.WriteLine(article);                // else 대신 if 문 안에서 continue
                }
                sw.Restart();

            }
            
        }

    }
}
