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
            /*using (var db = new BooksDbContext())
            {
                var book = db.Books.Single(x => x.Title == "별의 계승자");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }*/

            var db = new BooksDbContext();

            var authors = db.Authors.Where(a => a.Books.Count() >= 2);

            foreach (var item in authors)
            {
                Console.WriteLine($"{item.Name} {item.Gender} {item.Birthday}");
            }

            var books = db.Books.OrderBy(b => b.PublishedYear).ThenBy(b => b.Author.Name);
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
            }

            var groups = db.Books.GroupBy(b => b.PublishedYear).Select(g => new
            {
                Year = g.Key,
                Count = g.Count(),
            });

            foreach (var g in groups)
            {
                Console.WriteLine($"{g.Year} {g.Count}");
            }

            var author = db.Authors.Where(a => a.Books.Count() == db.Authors.Max(x => x.Books.Count())).First();

            Console.WriteLine($"{author.Name} {author.Gender} {author.Birthday}");
        }


  
    }
}
