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
            _repository.DeleteUser(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }

        public User GetUserByUserName(string userName)
        {
            return _repository.GetUserByUserName(userName);
        }

        public void PatchUser(User user)
        {
            _repository.PatchUser(user);
        }

        public void PostUser(User user)
        {
            _repository.PostUser(user);
        }
    }
}
