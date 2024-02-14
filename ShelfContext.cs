using Microsoft.EntityFrameworkCore;

namespace TEST
{
    public class ShelfContext : DbContext
    {
        public DbSet<Author> author { get; set; }
        public DbSet<Book> book { get; set; }
        public DbSet<AuthorBook> authorbook { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=next;database=TheShelf;integrated security=yes;encrypt=no");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(x => x.price).HasDefaultValue(100);
        }
    }
}
