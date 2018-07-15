using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13장.Models;
using System.Data.Entity;

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

            foreach (var book in GetBooks())
            {
                Console.WriteLine($"{book.Title} {book.Author.Name}");
            }

        }

        static IEnumerable<Book> GetBooks()
        {
            using (var db = new BooksDbContext())
            {
                return db.Books.Where(b => b.PublishedYear > 1900).Include(nameof(Author)).ToList();
            }
        }
  
    }
}
