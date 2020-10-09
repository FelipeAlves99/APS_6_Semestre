using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Infra.Data.Sql.Data.Context;
using System;
using System.Collections.Generic;

namespace APS_6.Infra.Data.Sql.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly APSContext _context = new APSContext();

        //public UserRepository(APSContext context)
        //{
        //    //_context = context;
        //}

        public void PostUser(User user)
        {
            _context.Set<User>().Add(user);
            _context.SaveChanges();
        }

        public void PatchUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
