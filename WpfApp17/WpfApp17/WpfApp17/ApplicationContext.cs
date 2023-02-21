using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<Book> Books { get; set; } = null!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source = HOME-PC; Initial Catalog = Shop; Trusted_Connection=True; TrustServerCertificate=True");
    }
}