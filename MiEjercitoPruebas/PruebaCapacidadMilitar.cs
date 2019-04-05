using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionEjercitos;


namespace MiEjercitoPruebas
{
    [TestClass]
    public class PruebaCapacidadMilitar
    {
        [TestMethod]
        public void Capacidad()
        {
            Ejercito
            Assert.AreEqual(DameCapacidadMilitar(20, 4, 20), 2);
        }
    }
}
