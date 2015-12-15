using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnattendedTest.Models;

namespace UnattendedTest.Tests.Helpers
{
    /// <summary>
    /// Basket model helper static class
    /// </summary>
    public static class BasketModelHelper
    {
        /// <summary>
        /// Gets a basket model for testing
        /// </summary>
        /// <returns>A <see cref="BasketModel"/> object</returns>
        public static BasketModel GetBasketModel()
        {
            return new BasketModel
            {
                User = new User
                {
                    Currency = "EUR",
                    EMail = "first.last@email.com",
                    FirstName = "First",
                    LastName = "Last",
                    Location = "South Yorkshire",
                    Address = new Address
                    {
                        Number = "9",
                        Street = "The Street",
                        City = "Sheffield",
                        Country = "England"
                    }
                },
                Postage = new Postage
                {
                    Carrier = "Post Carrier",
                    Cost = 9.89m
                },
                BasketItems = new BasketItem[]
                {
                    new BasketItem
                    {
                        ProductName = "Product 1",
                        Description = "Product number 1",
                        Cost = 5.50m,
                        Category = "Category A",
                        Image = "http://image.it/200x220.png"
                    },
                    new BasketItem
                    {
                        ProductName = "Product 2",
                        Description = "Product number 2",
                        Cost = 5.50m,
                        Category = "Category B",
                        Image = "http://image.it/200x220.png"
                    }
                }
            };
        }
    }
}
