using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Infra.Data.Sql.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace APS_6.Infra.Data.Sql.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly APSContext _context;

        public UserRepository(APSContext context)
        {
            _context = context;
        }

        public void PostUser(User user)
        {
            _context.Set<User>().Add(user);
            _context.SaveChanges();
        }

        public void PatchUser(User user)
        {
            _context.Attach(user);
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public User GetUserByUserName(string userName)
        {
            return _context.Users
                .AsNoTracking()
                .Where(u => u.UserName == userName)
                .FirstOrDefault();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users
                .AsNoTracking()
                .ToList();
        }

        public void DeleteUser(string userName)
        {
            _context.Set<User>().Remove(GetUserByUserName(userName));
            _context.SaveChanges();
        }

        public User Login(string name, string password)
            => _context.Users
                .AsNoTracking()
                .Where(u => u.UserName == name && u.Password == password)
                .FirstOrDefault();
    }
}
