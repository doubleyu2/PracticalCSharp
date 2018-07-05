using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using System.Diagnostics;
using System.IO;

namespace 실전연습2
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

                if (sw.Elapsed.TotalSeconds <= 1)
                {
                    //프로그램 대기
                    continue;

                }

                Console.Clear();

                var wc = new WebClient
                {
                    Encoding = Encoding.UTF8,
                   
                };

                wc.Headers.Add(HttpRequestHeader.Referer,"https://cafe.naver.com/joonggonara.cafe?iframe_url=/ArticleList.nhn%3Fsearch.clubid=10050146%26search.boardtype=L%26viewType=pc");
                wc.Headers.Add(HttpRequestHeader.Upgrade, "1");
                wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36");
                var src = wc.DownloadString("https://cafe.naver.com/joonggonara.cafe?iframe_url=/ArticleList.nhn%3Fsearch.clubid=10050146%26search.boardtype=L%26viewType=pc");

                HtmlDocument doc = new HtmlDocument();

                doc.LoadHtml(src);

 //               File.WriteAllText("htmlsource.html",src,Encoding.UTF8);

                var iframeNode = doc.DocumentNode.SelectSingleNode("//iframe[@name='cafe_main']");

                if (iframeNode==null)
                {
                    Console.WriteLine("Null");
                }

             //   Console.WriteLine(iframeNode.);

                break;
            }
            sw.Restart();
        }
    }
}
