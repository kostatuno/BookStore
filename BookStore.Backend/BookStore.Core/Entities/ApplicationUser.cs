using System;
using System.Collections.Generic;

namespace BookStore.Core.Entities
{
    public class ApplicationUser
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public decimal Balance { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime MemberSince { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}