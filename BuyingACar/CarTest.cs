using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuyingACar
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void OldPrice_10000_NewPrice_8000_Will_Return_Month_0_Left_2000()
        {
            var result = new[] { 0, 2000 };
            CollectionAssert.AreEqual(result, BuyCar.NbMonths(10000, 8000, 1000, 1.5));
        }
    }
}