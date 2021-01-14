using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var exptected = new Product(2)
            {
                ProductName = "berend@gmail.be",
                ProductDescription = "2 shovels",
                CurrentPrice = 6
            };

            // Act
            var actual = productRepository.Retrieve(2);

            // Asset
            Assert.AreEqual(exptected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(exptected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(exptected.ProductName, actual.ProductName);
        }
    }
}
