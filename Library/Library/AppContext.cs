using System.Data.Entity;

namespace Library
{
    public class AppContext : DbContext
    {
        public AppContext() : base("appContext") { }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}
