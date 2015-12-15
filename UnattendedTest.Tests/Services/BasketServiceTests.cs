using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnattendedTest.Models;
using UnattendedTest.Services;

namespace UnattendedTest.Tests.Services
{
    [TestClass]
    public class BasketServiceTests
    {
        [TestMethod]
        public void BasketService_CanGetBasket()
        {
            // Arrange
            var basketService = new BasketService();

            // Act
            var basketModel = basketService.GetBasket(Constants.BasketUrl);

            // Assert
            Assert.IsInstanceOfType(basketModel, typeof(BasketModel));
        }
    }
}
