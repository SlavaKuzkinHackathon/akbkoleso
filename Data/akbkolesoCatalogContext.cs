using Microsoft.EntityFrameworkCore;
using akbkoleso.Models.Admin.Catalog;

namespace akbkoleso.Data
{
    public class akbkolesoCatalogContext : DbContext
    {
        public DbSet<Catalog_tires_wheels> Catalog_tires_wheelss { get; set; }
        public DbSet<Podbor_akb> Podbor_akbs { get; set; }

        public akbkolesoCatalogContext(DbContextOptions<akbkolesoCatalogContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
