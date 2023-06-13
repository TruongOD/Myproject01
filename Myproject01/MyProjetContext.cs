using Microsoft.EntityFrameworkCore;
using Myproject01.Entities;

namespace Myproject01
{
    public class MyProjetContext : DbContext
    {
        public MyProjetContext(DbContextOptions<MyProjetContext> options) : base(options) { }
        public DbSet<Productrequest> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
