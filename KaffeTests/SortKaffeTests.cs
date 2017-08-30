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
    public class SortKaffeTests
    {
        [TestMethod()]
        public void PrisTestSortKaffe()
        {
            //Arrange
            var sortKaffe = new SortKaffe();
            //Act
            int pris = sortKaffe.Pris();
            //Assert
            Assert.AreEqual(20, pris);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PrisTest20()
        {
            //Arrange
            var sortKaffe = new SortKaffe(20);
            //Act
            int pris = sortKaffe.Pris();
            //Assert
            //none

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PrisTest21()
        {
            //Arrange
            var sortKaffe = new SortKaffe(21);
            //Act
            int pris = sortKaffe.Pris();
            //Assert
            //none

        }
    }
}