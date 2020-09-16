using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace APS_6.Domain.Entities
{
    public class Users
    {
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
