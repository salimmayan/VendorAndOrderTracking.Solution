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
            Vendor.ClearAll();
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

        [TestMethod]
        public void GetId_ReturnsVendorId_Int()
        {
            //Arrange
            string name = "Vendor Name";
            string description = "Vendor Description";
            Vendor newVendor = new Vendor(name, description);
            Vendor newVendor2 = new Vendor(name, description);
            Vendor newVendor3 = new Vendor(name, description);

            //Act
            int result = newVendor3.Id;

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            //Arrange
            string name01 = "Vendor Name-1";
            string name02 = "Vendor Name-2";
            string description01 = "Vendor Description-1";
            string description02 = "Vendor Description-2";
            Vendor newVendor01 = new Vendor(name01, description01);
            Vendor newVendor02 = new Vendor(name02, description02);
            List<Vendor> newList = new List<Vendor> { newVendor01, newVendor02 };

            //Act
            List<Vendor> result = Vendor.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result); // Two Objects are pushed into Static LIST and same two objects are pushed into a local LIST. Compare the 2 LISTS
        }

        [TestMethod]
        public void Find_ReturnsCorrectVendor_Vendor()
        {
            //Arrange
            string name01 = "Vendor Name-1";
            string name02 = "Vendor Name-2";
            string description01 = "Vendor Description-1";
            string description02 = "Vendor Description-2";
            Vendor newVendor01 = new Vendor(name01, description01);
            Vendor newVendor02 = new Vendor(name02, description02);

            //Act
            Vendor result = Vendor.Find(2);  //Check of newVendor02 obj match object in List location 2 

            //Assert
            Assert.AreEqual(newVendor02, result);
        }

    }
}