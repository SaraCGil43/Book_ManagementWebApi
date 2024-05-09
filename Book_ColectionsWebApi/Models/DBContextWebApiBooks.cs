using Microsoft.EntityFrameworkCore;

namespace Book_ColectionsWebApi.Models
{
    public class DBContextWebApiBooks : DbContext
    {
        public DBContextWebApiBooks(DbContextOptions<DBContextWebApiBooks> options) : base(options) { } //Inyección de dependencias

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>(b =>
            {
                b.HasKey(r => r.Id); // Definir la clave principal
            });
        }


    }
}
