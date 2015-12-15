namespace UnattendedTest.Models
{
    /// <summary>
    /// Class which models an address
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the house number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        public string Country { get; set; }
    }
}