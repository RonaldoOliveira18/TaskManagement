using FileMicroservice.Model;
using Microsoft.EntityFrameworkCore;

namespace FileMicroservice.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {

        }

        public DbSet<FileTaskEntity> FileTask { get; set; }
    }
}
