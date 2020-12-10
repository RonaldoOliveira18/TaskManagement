using IdentityMicroservice.Model;
using Microsoft.EntityFrameworkCore;

namespace IdentityMicroservice.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {

        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
