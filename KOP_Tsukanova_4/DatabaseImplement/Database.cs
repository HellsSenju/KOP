using Microsoft.EntityFrameworkCore;

namespace DatabaseImplement
{
    public class Database : DbContext
    {
        public virtual DbSet<Book> Books { set; get; }
        public virtual DbSet<Ganre> Ganres{ set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Library;Username=postgres;Password=password");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
