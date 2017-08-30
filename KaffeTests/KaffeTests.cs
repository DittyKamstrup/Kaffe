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
    public class KaffeTests
    {
        [TestMethod()]
        public void PrisTestKaffe()
        {
            //Arrange
            var kaffe = new SortKaffe();
            //Act
            int pris = kaffe.Pris();
            //Assert
            Assert.AreEqual(20, pris);
        }

        [TestMethod()]
        public void StyrkeTestKaffe()
        {
            //Arrange
            var kaffe = new SortKaffe();
            //Act
            string styrke = kaffe.Styrke();
            //Assert
            Assert.AreEqual("Stærk", styrke);
        }

        [TestMethod()]
        public void TestKaffeListe()
        {
            //Arrange
            var kaffeListe = new List<Imælk>();
            var cortado = new Cortado();
            var latte = new Latte();

            //SortKaffe har ikke implementeret Imælk interface, derfor kan det ikke indsættes til List<Imælk>
            //var sortKaffe = new SortKaffe();
            //kaffeListe.Add(sortKaffe);

            kaffeListe.Add(cortado);
            kaffeListe.Add(latte);

            //Act
            int total = 0;

            foreach (var kaffeItem in kaffeListe)
            {
                total += kaffeItem.mlMælk();

                //if (kaffeItem is Cortado)
                //{
                //    var localCortado = kaffeItem as Cortado;
                //}
                //kaffeItem.mlMælk();
            }

            //Assert
            Assert.AreEqual(145, total);
        }
    }
}