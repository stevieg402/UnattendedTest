using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnattendedTest.Controllers;
using Moq;
using UnattendedTest.Services.Interfaces;
using UnattendedTest.Models;
using System.Web.Mvc;
using UnattendedTest.Tests.Helpers;

namespace UnattendedTest.Tests.Controllers
{
    [TestClass]
    public class BasketControllerTests
    {
        Mock<IConfigService> configServiceMock;

        Mock<IBasketService> basketServiceMock;

        [TestInitialize]
        public void Initialize()
        {
            configServiceMock = new Mock<IConfigService>();
            basketServiceMock = new Mock<IBasketService>();
        }

        [TestMethod]
        public void BasketController_CanConstruct()
        {
            // Act
            using (var controller = new BasketController(configServiceMock.Object, basketServiceMock.Object))
            {
                // Assert
                Assert.IsInstanceOfType(controller, typeof(BasketController));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BasketController_ConstructorThrowsExceptionWhenBasketServiceIsNull()
        {
            // Act
            using (var controller = new BasketController(configServiceMock.Object, null))
            {
                // Assert
                Assert.Fail("Should not get here");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BasketController_ConstructorThrowsExceptionWhenConfigServiceIsNull()
        {
            // Act
            using (var controller = new BasketController(null, null))
            {
                // Assert
                Assert.Fail("Should not get here");
            }
        }

        [TestMethod]
        public void BasketController_IndexReturnsModel()
        {
            // Arrange
            var basket = BasketModelHelper.GetBasketModel();

            configServiceMock.Setup(csm => csm.GetSetting(It.Is<string>(s => s == Constants.BasketUrlConfigurationKey))).Returns(Constants.BasketUrl);

            basketServiceMock.Setup(bsm => bsm.GetBasket(It.Is<string>(s => s == Constants.BasketUrl))).Returns(basket);

            using (var controller = new BasketController(configServiceMock.Object, basketServiceMock.Object))
            {
                // Act
                var result = controller.Index();

                // Assert
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(ViewResult));

                Assert.IsInstanceOfType(result.Model, typeof(BasketModel));

                var model = (BasketModel)result.Model;

                Assert.AreEqual("EUR", model.User.Currency);

                Assert.AreEqual("Post Carrier", model.Postage.Carrier);

                Assert.AreEqual(2, model.BasketItems.Length);
            }
        }

        [TestMethod]
        public void BasketController_IndexCallsServices()
        {
            // Arrange
            var basket = BasketModelHelper.GetBasketModel();

            configServiceMock.Setup(csm => csm.GetSetting(It.Is<string>(s => s == Constants.BasketUrlConfigurationKey))).Returns(Constants.BasketUrl);

            basketServiceMock.Setup(bsm => bsm.GetBasket(It.Is<string>(s => s == Constants.BasketUrlConfigurationKey))).Returns(basket);

            // Act
            using (var controller = new BasketController(configServiceMock.Object, basketServiceMock.Object))
            {
                controller.Index();
            }

            // Verify
            configServiceMock.Verify(csm => csm.GetSetting(It.Is<string>(s => s == Constants.BasketUrlConfigurationKey)), Times.Once);

            basketServiceMock.Verify(bsm => bsm.GetBasket(It.Is<string>(s => s == Constants.BasketUrl)), Times.Once);
        }
    }
}
