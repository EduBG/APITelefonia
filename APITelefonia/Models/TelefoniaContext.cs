namespace APITelefonia.Models
{
    using Microsoft.EntityFrameworkCore;
    using APITelefonia.Models;

    public class TeefoniaContext
        : DbContext
    {
        public TeefoniaContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Terminal> Terminales { get; set; }
    }
}