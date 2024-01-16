using Microsoft.EntityFrameworkCore;


namespace Портфолио.Models
{
    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions<dbContext> options)
        : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Review> Review { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
