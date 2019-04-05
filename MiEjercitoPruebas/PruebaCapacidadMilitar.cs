using Microsoft.VisualStudio.TestTools.UnitTesting;
 

namespace MiEjercitoPruebas
{
    [TestClass]
    public class PruebaCapacidadMilitar
    {
        [TestMethod]
        public void Capacidad()
        {
            
            Assert.AreEqual(DameCapacidadMilitar(20, 4, 20), 2);
        }
    }
}
