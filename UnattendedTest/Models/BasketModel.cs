using Newtonsoft.Json;
using System.Linq;

namespace UnattendedTest.Models
{
    /// <summary>
    /// Class which models the basket model
    /// </summary>
    public class BasketModel
    {
        /// <summary>
        /// Gets or sets the user
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the array of basket items
        /// </summary>
        [JsonProperty(PropertyName = "Basket")]
        public BasketItem[] BasketItems { get; set; }

        /// <summary>
        /// Gets or sets the postage details
        /// </summary>
        public Postage Postage { get; set; }

        /// <summary>
        /// Gets the total cost of all basket items and postage
        /// </summary>
        public decimal TotalCost
        {
            get
            {
                decimal itemCost = (from bi in this.BasketItems
                                       select bi.Cost).Sum();

                return itemCost + this.Postage.Cost;
            }
        }
    }
}