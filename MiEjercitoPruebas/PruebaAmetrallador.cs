using Microsoft.VisualStudio.TestTools.UnitTesting;

using Ejercito;

namespace MiEjercitoPruebas
{
    [TestClass]
    public class PruebaAmetrallador
    {
        [TestMethod]
        public void Ametralladora()
        {
            Ametrallador metralla = new Ametrallador(10, "Jorge", 20 ,300 ,20);
            Assert.AreEqual(metralla.DamePotenciaDeFuego(), 20);
            Assert.AreEqual(metralla.DameVelocidad(), 20);
            Assert.AreEqual(metralla.DameCapacidadMilitar(), 2);
        }
    }
}
