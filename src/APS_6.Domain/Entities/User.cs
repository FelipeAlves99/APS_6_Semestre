using APS_6.Domain.Enums;

namespace APS_6.Domain.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public EAccessLevel Permission { get; private set; }         
    }
}
