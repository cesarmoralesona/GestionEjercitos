using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public class TAXIN_66 : ICaballeria, IUnidad, IMovil, IPreciable
    {
        public int ID { get; set; }
        public string NombreSanitario { get; set; }

        public IEjercito IEjercito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double DameCapacidadMilitar()
        {
            throw new NotImplementedException();
        }

        public void DamePrecio()
        {
            throw new NotImplementedException();
        }

        public void DameVelocidad()
        {
            throw new NotImplementedException();
        }
    }
}