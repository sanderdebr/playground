using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var exptected = new Customer(1)
            {
                EmailAddress = "berend@gmail.be",
                FirstName = "Berend",
                LastName = "Balzaq"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(exptected.EmailAddress, actual.EmailAddress);
        }
    }
}
