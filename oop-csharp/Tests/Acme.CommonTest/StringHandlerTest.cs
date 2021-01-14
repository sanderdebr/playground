using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "SonicBerend";
            var exptected = "Sonic Berend";

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(exptected, actual);
        }
    }
}
