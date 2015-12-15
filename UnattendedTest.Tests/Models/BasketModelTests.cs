using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnattendedTest.Tests.Helpers;

namespace UnattendedTest.Tests.Models
{
    [TestClass]
    public class BasketModelTests
    {
        [TestMethod]
        public void BasketModel_CanCalculateTotalCost()
        {
            var basketModel = BasketModelHelper.GetBasketModel();

            decimal totalCost = basketModel.Postage.Cost;

            foreach (var basketItem in basketModel.BasketItems)
            {
                totalCost += basketItem.Cost;
            }

            Assert.AreEqual(totalCost, basketModel.TotalCost);
        }
    }
}
