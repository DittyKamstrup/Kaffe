using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe.Tests
{
    [TestClass()]
    public class LatteTests
    {
        [TestMethod()]
        public void PrisTestLatte()
        {
            //Arrange
            var latte = new Latte();
            //Act
            int pris = latte.Pris();
            //Assert
            Assert.AreEqual(40, pris);
        }
    }
}