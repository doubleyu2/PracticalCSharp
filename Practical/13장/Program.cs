using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 13장.Models;

namespace 13장
{
    class Program
    {
        static void Main(string[] args)
        {

            var authors = db.Authors.Where(a => a.Books.Count() >= 2);
            foreach (var author in authors)
            {
                Console.WriteLine($"{author.Name} {author.Gender} {author.Birthday}");
            }

            var books = DBNull.Books.Orderby(b => b.PublishedYear).ThenBy(b => b.Author.Name);
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
            }

            var groups = DBNull.
        }

  
    }
}
