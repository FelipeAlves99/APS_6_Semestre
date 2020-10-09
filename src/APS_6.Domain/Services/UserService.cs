using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace APS_6.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void DeleteUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public User GetUserByUserName(string userName)
        {
            throw new System.NotImplementedException();
        }

        public void PatchUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void PostUser(User user)
        {
            _repository.PostUser(user);
        }
    }
}
