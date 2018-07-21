using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13장_연습문제_정답.Models;
using System.Data.Entity;

namespace _13장_연습문제_정답
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookDbContext())
            {

                db.Books.Add(new Book
                {
                    Author = new Author { Name = "스티븐 킹", Birthday = new DateTime(1947, 9, 21), Gender = "M" },
                    Title = "샤이닝",
                    PublishedYear = 1887,
                    
                });
                db.SaveChanges();
            }
        }
    }
}
