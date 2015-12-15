using System;
using System.Web.Mvc;
using UnattendedTest.Services.Interfaces;

namespace UnattendedTest.Controllers
{
    /// <summary>
    /// Class which models the basket controller
    /// </summary>
    public class BasketController : Controller
    {
        private readonly IConfigService configService;
        private readonly IBasketService basketService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configService">The configurarion service</param>
        /// <param name="basketService">The basket servi e</param>
        /// <exception cref="ArgumentNullException">Thrown when either of the <paramref name="configService"/> or <paramref name="basketService"/> parameters is null</exception>
        public BasketController(IConfigService configService, IBasketService basketService)
        {
            if (configService == null)
            {
                throw new ArgumentNullException("configService");
            }

            if (basketService == null)
            {
                throw new ArgumentNullException("basketService");
            }

            this.configService = configService;
            this.basketService = basketService;
        }

        // GET: Basket
        /// <summary>
        /// Returns the Index view
        /// </summary>
        /// <returns>A <see cref="ViewResult"/> object</returns>
        public ViewResult Index()
        {
            var model = this.basketService.GetBasket(this.configService.GetSetting(Constants.BasketUrlConfigurationKey));
            return View(model);
        }
    }
}