using Microsoft.VisualStudio.TestTools.UnitTesting;

using Ejercito;

namespace MiEjercitoPruebas
{
    [TestClass]
    public class PruebaCañon
    {
        [TestMethod]
        public void Capacidad()
        {
            Cañon cañonsito = new Cañon(10,"Jorge",20,150);
            Assert.AreEqual(cañonsito.DamePotenciaDeFuego(),20);
        }
    }
}
