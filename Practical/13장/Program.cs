using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13장.Models;

namespace _13장
{
    class Program
    {
        static void Main(string[] args)
        {
            //            InsertBooks();
           var resultlist = GetBook();
            foreach (var item in resultlist)
            {
                Console.WriteLine(item.Title);
            }
        }

        static IEnumerable<Book> GetBook()
        {
            using (var db = new BooksDbContext())
            {
                return db.Books
                        .Where(book => book.Author.Name.StartsWith("제임스"))
                        .ToList(); 
            }
        }




        static void InsertBooks()
        {
            using (var db = new BooksDbContext())
            {
                var book1 = new Book
                {
                    Title = "별의 계승자",
                    PublishedYear = 1977,
                    Author = new Author
                    {
                        Birthday = new DateTime(1941, 6, 27),
                        Gender = "M",
                        Name = "제임스 P. 호건"
                    }

                };

                db.Books.Add(book1);

                var book2 = new Book
                {
                    Title = "타임머신",
                    PublishedYear = 1895,
                    Author = new Author
                    {
                        Birthday = new DateTime(1866, 9, 21),
                        Gender = "M",
                        Name = "허버트 조지 웰즈",
                    }
                };

                db.Books.Add(book2);

                db.SaveChanges();    // DB 에 저장. 맨마지막에 실행하게 함 
            }
        }
    }
}
