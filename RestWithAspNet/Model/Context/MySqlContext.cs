using Microsoft.EntityFrameworkCore;

namespace RestWithAspNet.Model.Context
{
    public class MySqlContext:DbContext
    {
        public MySqlContext()
        {            
        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Movie> Movie { get; set; }

    }
}
