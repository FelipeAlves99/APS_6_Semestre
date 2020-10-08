using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Infra.Data.Sql.Data.Context;
using System;

namespace APS_6.Infra.Data.Sql.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly APSContext _context = new APSContext();

        //public UserRepository(APSContext context)
        //{
        //    //_context = context;
        //}

        public void AddUser(User user)
        {
            _context.Set<User>().Add(user);
            _context.SaveChanges();
        }
    }
}
