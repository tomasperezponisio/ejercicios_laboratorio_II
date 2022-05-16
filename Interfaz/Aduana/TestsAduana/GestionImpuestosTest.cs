using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestsAduana
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            //Arrange            
            GestionImpuestos gestion = new GestionImpuestos();
            PaquetePesado paquetePesado = new PaquetePesado("abc123", 500m, "Tres Arroyos", "CABA", 1);
            PaqueteFragil paqueteFragil = new PaqueteFragil("abc123", 500m, "Tres Arroyos", "CABA", 1);
            gestion.RegistrarImpuestos(paquetePesado);
            gestion.RegistrarImpuestos(paqueteFragil);

            decimal expected = 350m;
            decimal actual;

            //Act
            actual = gestion.CalcularTotalImpuestosAduana();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalcularTotalImpuestos_DeberiaRetornarLaSumaDeLosImpuestosAfip()
        {

            //Arrange            
            GestionImpuestos gestion = new GestionImpuestos();
            PaquetePesado paquetePesado = new PaquetePesado("abc123", 500m, "Tres Arroyos", "CABA", 1);
            PaqueteFragil paqueteFragil = new PaqueteFragil("abc123", 500m, "Tres Arroyos", "CABA", 1);
            gestion.RegistrarImpuestos(paquetePesado);
            gestion.RegistrarImpuestos(paqueteFragil);

            decimal expected = 125m;
            decimal actual;

            //Act
            actual = gestion.CalcularTotalImpuestosAfip();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
