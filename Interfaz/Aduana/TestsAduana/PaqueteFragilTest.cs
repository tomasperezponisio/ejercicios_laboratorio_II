using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestsAduana
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //Arrange            
            PaqueteFragil paqueteFragil = new PaqueteFragil("abc123", 500, "Tres Arroyos", "CABA", 1);

            decimal expected = 675m;
            decimal actual;

            //Act
            actual = paqueteFragil.AplicarImpuestos();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //Arrange            
            PaqueteFragil paqueteFragil = new PaqueteFragil("abc123", 500, "Tres Arroyos", "CABA", 1);

            decimal expected = 175m;
            decimal actual;

            //Act
            actual = paqueteFragil.Impuestos;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange            
            PaqueteFragil paqueteFragil = new PaqueteFragil("abc123", 500, "Tres Arroyos", "CABA", 1);
            
            bool expected = true; 
            bool actual;

            //Act
            actual = paqueteFragil.TienePrioridad;

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
