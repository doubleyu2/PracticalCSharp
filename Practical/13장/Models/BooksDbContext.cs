namespace _13장.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BooksDbContext : DbContext
    {
       public BooksDbContext()
            : base("name=BooksDbContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }

}