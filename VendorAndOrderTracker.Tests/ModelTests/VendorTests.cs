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
        public void GetDescription_ReturnDescription_String()
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

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            //Arrange
            string name = "Vendor Name";
            string description = "Vendor Description";
            Vendor newVendor = new Vendor(name, description);

            //Act
            string result = newVendor.Name;

            //Assert
            Assert.AreEqual(name, result);
        }

        [TestMethod]
    public void SetName_SetName_String()
    {
      //Arrange
      string name = "Vendor Name";
      string description = "Vendor Description";
      Vendor newVendor = new Vendor(name, description);

      //Act - //Created an object; next gave property new value using dot operator; 
      // Check if Object "took" the new value passed thru dot operator
      string updatedName = "New Vendor Name"; 
      newVendor.Name = updatedName;
      string result = newVendor.Name;


      //Assert
      Assert.AreEqual(updatedName, result);
    }

    }
}