using IdentityMicroservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMicroservice.Repository
{
    public interface IUserRepository
    {
        public UserEntity GetUserBYEmail(string email);
        public void InsertUser(UserEntity entity);
    }
}
