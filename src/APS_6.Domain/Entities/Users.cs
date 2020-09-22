namespace APS_6.Domain.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public AccessLevel Permission { get; set; } 

        public enum AccessLevel
        {
            Admin,
            Manager,
            Analyst,
            Reporter
        }
    }
}
