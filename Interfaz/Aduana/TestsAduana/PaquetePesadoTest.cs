using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestsAduana
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            //Arrange            
            PaquetePesado paquetePesado = new PaquetePesado("abc123", 500m, "Tres Arroyos", "CABA", 1);

            decimal expected = 800m;
            decimal actual;

            //Act
            actual = paquetePesado.AplicarImpuestos();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            //Arrange            
            PaquetePesado paquetePesado = new PaquetePesado("abc123", 500m, "Tres Arroyos", "CABA", 1);

            decimal expected = 125m;
            decimal actual;

            //Act
            actual = ((IAfip)paquetePesado).Impuestos;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //Arrange            
            PaquetePesado paquetePesado = new PaquetePesado("abc123", 500, "Tres Arroyos", "CABA", 1);

            decimal expected = 175m;
            decimal actual;

            //Act
            actual = paquetePesado.Impuestos;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange            
            PaquetePesado paquetePesado = new PaquetePesado("abc123", 500m, "Tres Arroyos", "CABA", 1);

            bool expected = false;
            bool actual;

            //Act
            actual = paquetePesado.TienePrioridad;

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
