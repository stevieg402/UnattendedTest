using Newtonsoft.Json;
using System.Net;
using UnattendedTest.Models;
using UnattendedTest.Services.Interfaces;

namespace UnattendedTest.Services
{
    /// <summary>
    /// Class which models an implementation the basket service interface
    /// </summary>
    public class BasketService : IBasketService
    {
        /// <summary>
        /// Gets basket contents from the specified <paramref name="requestUri"/>
        /// </summary>
        /// <param name="requestUri">The request uri</param>
        /// <returns>A <see cref="BasketModel"/> object</returns>
        public BasketModel GetBasket(string requestUri)
        {
            using (var webClient = new WebClient())
            {
                string s = webClient.DownloadString(requestUri);

                var basket = JsonConvert.DeserializeObject<BasketModel>(s);

                return basket;
            }
        }
    }
}