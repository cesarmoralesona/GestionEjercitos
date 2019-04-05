using Microsoft.VisualStudio.TestTools.UnitTesting;

using Ejercito;

namespace MiEjercitoPruebas
{
    [TestClass]
    public class PruebaCapacidadMilitar
    {
        [TestMethod]
        public void Capacidad()
        {
            Cañon cañonsito = new Cañon(1,"Jorge",20,1500);
            Assert.AreEqual(cañonsito.DamePotenciaDeFuego(),20,0.001);
        }
    }
}
