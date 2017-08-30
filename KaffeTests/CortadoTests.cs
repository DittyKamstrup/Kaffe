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
    public class CortadoTests
    {
        [TestMethod()]
        public void PrisTestCortado()
        {
            //Arrange
            var cortado = new Cortado();
            //Act
            int pris = cortado.Pris();
            //Assert
            Assert.AreEqual(25, pris);
        }
    }
}