using UnattendedTest.Models;

namespace UnattendedTest.Services.Interfaces
{
    /// <summary>
    /// Interface which defines the basket service contract
    /// </summary>
    public interface IBasketService
    {
        /// <summary>
        /// Gets basket contents from the specified <paramref name="requestUri"/>
        /// </summary>
        /// <param name="requestUri">The request uri</param>
        /// <returns>A <see cref="BasketModel"/> object</returns>
        BasketModel GetBasket(string requestUri);
    }
}
