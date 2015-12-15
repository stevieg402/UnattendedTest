namespace UnattendedTest.Models
{
    /// <summary>
    /// Class which models a basket item
    /// </summary>
    public class BasketItem
    {
        /// <summary>
        /// Gets or sets the product name
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the cost
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets the category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the image url
        /// </summary>
        public string Image { get; set; }
    }
}