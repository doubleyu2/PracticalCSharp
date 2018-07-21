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
                var author1 = new Author
                {
                    Name = "스티븐 킹",
                    Birthday = new DateTime(1947, 9, 21),
                    Gender = "M",
                };
                db.Authors.Add(author1);

                var author2 = new Author
                {
                    Name = "윌리엄 골딩",
                    Birthday = new DateTime(1911, 9, 19),
                    Gender = "F"
                };
                db.Authors.Add(author2);


                var book1 = new Book
                {
                    Title = "샤이닝",
                    PublishedYear = 1977,
                    Author = author1,
                };
                var book2 = new Book
                {
                    Title = "밀물을 타고",
                    PublishedYear = 1948,
                    Author = new Author { Name = "애거사 크리스티", Birthday = new DateTime(1900, 1, 1), Gender = "F" },
                };

                var book3 = new Book
                {
                    Title = "크리스마스 캐럴",
                    PublishedYear = 1843,
                    Author = new Author { Name = " 찰스 디킨스", Birthday = new DateTime(1921, 1, 1), Gender = "M" },
                };
                var book4 = new Book
                {
                    Title = "파리대왕",
                    PublishedYear = 1954,
                    Author = author2,
                };

                db.Books.Add(book1);
                db.Books.Add(book2);
                db.Books.Add(book3);
                db.Books.Add(book4);
            
                db.SaveChanges();
            }
        }
    }
}
