using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;


namespace VendorAndOrderTracker.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {

        public void Dispose()
        {
            // Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("test Vendor Name", "trial Vendor desciption");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnDescription_Description()
        {
            Vendor newVendor = new Vendor("someName", "someDescription");
            string description = "someDescription";
            Assert.AreEqual(description, newVendor.Description);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //Arrange
            string name = "Vendor Name";
            string description = "Vendor Description";
            Vendor newVendor = new Vendor(name, description);

            //Act
            string updatedDescription = "Updated Vendor Description";
            newVendor.Description = updatedDescription;
            string result = newVendor.Description;


            //Assert
            Assert.AreEqual(updatedDescription, result);
        }

    }
}