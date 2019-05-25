
using System.Collections.Generic;

namespace Sri.BL
{
    public class Customer
    {
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            Addresses = new List<Address>();
        }

        /// <summary>
        /// 
        /// </summary>
        public int CustomerId { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int CustomerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EmailAddress { get; set; }

        public List<Address> Addresses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FullName
        {
            get { return $"{FirstName}, {LastName}"; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static int InstanceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName)) isValid = false;
            return isValid;
        }
    }
}
