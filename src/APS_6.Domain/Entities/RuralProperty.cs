using System;
using System.Collections.Generic;
using System.Text;

namespace APS_6.Domain.Entities
{
    public class RuralProperty
    {
        public string CompanyName { get; set; }
        public List<Address> Address { get; set; }
    }
}
