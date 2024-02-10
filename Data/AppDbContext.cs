using CEPvia.Models;
using Microsoft.EntityFrameworkCore;

namespace Info.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("DataSource=app.db;Cache=Shared");

    }
}
