using IdentityMicroservice.Context;
using IdentityMicroservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMicroservice.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly CRUDContext _context;

        public UserRepository(CRUDContext context)
        {
            _context = context;
        }
            
        public UserEntity GetUserBYEmail(string email) =>
            _context.Users.SingleOrDefault(x => x.Email == email);

        public void InsertUser(UserEntity entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

    }
}
