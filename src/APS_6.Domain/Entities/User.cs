using APS_6.Domain.Enums;

namespace APS_6.Domain.Entities
{
    public class User : Entity
    {
        public User(string userName, string password, string name, EAccessLevel permission)
        {
            UserName = userName;
            Password = password;
            Name = name;
            Permission = permission;
        }

        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public EAccessLevel Permission { get; private set; }
    }
}
