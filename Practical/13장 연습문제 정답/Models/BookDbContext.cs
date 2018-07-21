namespace _13장_연습문제_정답.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookDbContext : DbContext
    {
         
        public BookDbContext()
            : base("name=BookDbContext")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<BookDbContext, Configuration>());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


    }

   
}