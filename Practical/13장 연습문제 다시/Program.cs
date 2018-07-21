using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13장_연습문제_다시.Models;

namespace _13장_연습문제_다시
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BooksDbContext())
            {
                //// 가장 긴 제목의 길이 (int)
                //int LengthTitle = db.Books.Max(b => b.Title.Length);
                //// 그 길이에 해당되는 책 목록 구하기 where

                //var maxLengthBooks = db.Books.Where(b => b.Title.Length == LengthTitle);

                //foreach (var book in maxLengthBooks)
                //{
                //    Console.WriteLine(book.Title);
                //}

                //Console.WriteLine();

                //// 발행년도 오래된 순서로 3권, 제목과 저자 
                //var oldestBooks = db.Books.OrderBy(b => b.PublishedYear).Take(3);
                //foreach (var book in oldestBooks)
                //{
                //    Console.WriteLine($"{book.Title}-{book.PublishedYear}-{book.Author.Name}");
                //}

                // 각 저자의 서적 제목과 발행연도 표시. 저자는 생일이 늦은 순서로 나열

                foreach (var author in db.Authors.OrderByDescending(a => a.Birthday))
                {
                    Console.WriteLine($"{author.Name}");
                    Console.WriteLine($"{author.Books.Count()}");
                    foreach (var item in author.Books)
                    {

                        Console.WriteLine($"-{item.Title},  {item.PublishedYear}");
                    }
                }
            }

        }
    }
}
