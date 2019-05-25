
namespace Sri.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        /// <summary>
        /// 
        /// </summary>
        public int ProductId { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Description) || CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
