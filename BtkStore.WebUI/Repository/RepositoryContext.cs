using BtkStore.WebUI.Models;
using Microsoft.EntityFrameworkCore;

namespace BtkStore.WebUI.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
