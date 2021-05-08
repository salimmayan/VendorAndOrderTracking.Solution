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
        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description = "someDesc";
            Order newOrder = new Order(description, "someTitle", 10);
            string returnedDescription = newOrder.Description;
            Assert.AreEqual(description, returnedDescription);

        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            string description = "someDesc";
            Order newOrder = new Order(description, "someTitle", 10);
            string returnedDescription = newOrder.Description;

            string newDescription = "differentDescription";
            newOrder.Description = newDescription;
            Assert.AreEqual(newDescription, newOrder.Description);

        }

        [TestMethod]
        public void GetPrice_ReturnsPrice_Int()
        {
            //Arrange
            string description = "Trial Order";
            string title = "Crossant order";
            int price = 35;
            Order newOrder = new Order(description, title, price);

            //Act
            int result = newOrder.Price;

            //Assert
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void SetPrice_SetPrice_Int()
        {
            //Arrange
            string description = "Trial Order";
            string title = "Crossant order";
            int price = 35;
            Order newOrder = new Order(description, title, price);

            //Act
            int updatedPrice = 45;
            newOrder.Price = updatedPrice;
            int result = newOrder.Price;


            //Assert
            Assert.AreEqual(updatedPrice, result);
        }

    }
}