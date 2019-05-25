
namespace Sri.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        /// <summary>
        /// 
        /// </summary>
        public int AddressId { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int AddressType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StreetLineOne { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StreetLineTwo { get; set; }

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
            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;
            return isValid;
        }
    }
}
