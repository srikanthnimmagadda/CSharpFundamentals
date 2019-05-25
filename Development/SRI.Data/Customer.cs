using System;
using System.Collections.Generic;
using System.Text;

namespace SRI.Data
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get { return $"{FirstName}, {LastName}"; }
        }

    }
}
