using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public class Cañon : IArtilleria, IUnidad, IDestructor, IPreciable
    {
        private double potfuego;
        private double precioUnid;
        public Cañon(int iD, string nombreCañon,  double potenciaDeFuego, double precio)
        {
            ID = iD;
            NombreCañon = nombreCañon ?? throw new ArgumentNullException(nameof(nombreCañon));
            //IEjercito = ejercito ?? throw new ArgumentNullException(nameof(ejercito));
            PotenciaDeFuego = potenciaDeFuego;
            Precio = precio;
        }

        public int ID { get; set; }
        public string NombreCañon { get; set; }

        public IEjercito IEjercito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double PotenciaDeFuego { get => potfuego; set => potfuego = value; }
        public double Precio { get => precioUnid; set => precioUnid = value; }

        public double DamePotenciaDeFuego()
        {
            return PotenciaDeFuego;
        }

        public void DamePrecio()
        {
            throw new NotImplementedException();
        }

       
    }
}