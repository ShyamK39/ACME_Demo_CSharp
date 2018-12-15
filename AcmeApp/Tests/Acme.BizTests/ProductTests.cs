using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            //Arrange

            //setting properties - best when populating database values
            var currentProduct = new Product();
            currentProduct.ProductId = 1;
            currentProduct.ProductName = "Saw";
            currentProduct.Description = "15 inch steel blade hand saw";
            var expected = "Hello Saw (1): 15 inch steel blade hand saw";

            //Act
            var actual = currentProduct.SayHello();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHello_ParameterizedConstructor()
        {
            //Arrange
            //parameterized constructor - setting basic set of properties
            //var currentProduct = new Product(1, "Saw",
            //    "15 inch steel blade hand saw");

            //object initializer - calls default constructor + sets properties
            //best when readability is important + initializing subset / superset
            var currentProduct = new Product
            {
                ProductId = 1,
                ProductName = "Saw",
                Description = "15 inch steel blade hand saw"
            };

            var expected = "Hello Saw (1): 15 inch steel blade hand saw";

            //Act
            var actual = currentProduct.SayHello();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Product_Null()
        {
            Product currentProduct = null;
            var companyName = currentProduct?.ProductVendor?.CompanyName;

            string expected = null;

            var actual = companyName;

            Assert.AreEqual(expected, actual);
        }
    }
}