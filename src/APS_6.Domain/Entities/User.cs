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

        public void UpdateUserName(string username)
            => UserName = username;

        public void UpdatePassword(string password)
            => Password = password;

        public void UpdateName(string name)
            => Name = name;

        public void UpdatePermission(EAccessLevel permission)
            => Permission = permission;
    }
}
