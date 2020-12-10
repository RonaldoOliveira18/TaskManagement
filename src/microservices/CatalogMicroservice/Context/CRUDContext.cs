using CatalogMicroservice.Model;
using Microsoft.EntityFrameworkCore;

namespace CatalogMicroservice.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {

        }

        public DbSet<TaskEntity> tasks { get; set; }
    }
}
