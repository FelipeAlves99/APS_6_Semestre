using System;
using System.Collections.Generic;
using System.Text;

namespace APS_6.Domain.Entities
{
    public class Address
    {
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
