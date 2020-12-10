using Microsoft.EntityFrameworkCore;
using TasksMicroservice.Model;

namespace TasksMicroservice.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {

        }

        public DbSet<TaskEntity> Tasks { get; set; }
    }
}
