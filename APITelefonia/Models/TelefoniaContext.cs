namespace APITelefonia.Models
{
    using Microsoft.EntityFrameworkCore;
    using APITelefonia.Models;
    using Microsoft.Extensions.Configuration;
    using System.IO;

    public class TelefoniaContext
        : DbContext
    {
        public TelefoniaContext()
        {

        }
        public TelefoniaContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Terminal> Terminales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("EduCnn");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}