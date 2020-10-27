using APS_6.Domain.Entities;
using System.Collections.Generic;

namespace APS_6.Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        void PostUser(User user);        
        void PatchUser(User user);        
        User GetUserByUserName(string userName);        
        IEnumerable<User> GetAllUsers();        
        void DeleteUser(string userName);        
    }
}
