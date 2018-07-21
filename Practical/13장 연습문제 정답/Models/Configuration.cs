using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13장_연습문제_정답.Models
{
    internal sealed class Configuration : DbMigrationsConfiguration<BookDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "_13장_연습문제_정답.Models.BookDbContext";
        }
    }
  
}
