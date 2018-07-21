using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using _13장_연습문제.Models;


namespace _13장_연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            AddAuthors();
            AddBooks();

            var group = GetBooks();
            foreach (var item in group)
            {
                Console.WriteLine($"{item.Title}-{item.Author.Name}");
            }
                        
        }

        public static IEnumerable<Book> GetBooks()
        {
            using (var db = new BooksDbContext())
            {
                return db.Books.Include(nameof(Author));
            }
        }


        private static void AddAuthors()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = new Author
                {
                    Name = "스티븐 킹",
                    Birthday = new DateTime(1947, 09, 21),
                    Gender = "M",
                };
                db.Authors.Add(author1);

                var author2 = new Author
                {
                    Name = "윌리엄 골딩",
                    Birthday = new DateTime(1011, 09, 19),
                    Gender = "F",
                };
                db.Authors.Add(author2);
                db.SaveChanges();
            }
        }

        private static void AddBooks()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "스티븐 킹");
                var author2 = db.Authors.Single(a => a.Name == "윌리엄 골딩");
                var author3 = db.Authors.Single(a => a.Name == "찰스 디킨스");
                var author4 = db.Authors.Single(a => a.Name == "애거사 크리스티");

                var book1 = new Book
                {
                    Title = "샤이닝",
                    PublishedYear = 1977,
                    Author = author1,
                };

                db.Books.Add(book1);

                var book2 = new Book
                {
                    Title = "밀물을 타고",
                    PublishedYear = 1948,
                    Author = author4,
                };
                db.Books.Add(book2);

                var book3 = new Book
                {
                    Title = "크리스마스 캐럴",
                    PublishedYear = 1843,
                    Author = author3,
                };
                db.Books.Add(book3);

                var book4 = new Book
                {
                    Title = "파리대왕",
                    PublishedYear = 1954,
                    Author = author2,
                };
                db.Books.Add(book4);
                db.SaveChanges(); 
            }
        }

    }
}
