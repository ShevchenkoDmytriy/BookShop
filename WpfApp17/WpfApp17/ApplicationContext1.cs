using Microsoft.EntityFrameworkCore;

public class ApplicationContext1 : DbContext
{
    public DbSet<User> Users { get; set; } = null!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source = HOME-PC; Initial Catalog = Shop; Trusted_Connection=True; TrustServerCertificate=True");
    }
}
