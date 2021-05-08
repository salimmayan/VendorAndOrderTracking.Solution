using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
    [TestClass]
    public class OrderTest : IDisposable
    {

        public void Dispose()
        {

        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("someDesc", "someTitle", 10);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

    }
}