using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public class MX_7899 : ICaballeria, IMovil, IBlindado, IPreciable, IUnidad
    {
        public int ID { get; set; }
        public string NombreMX_7899 { get; set; }

        public IEjercito IEjercito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Blindaje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double DameBlindaje()
        {
            throw new NotImplementedException();
        }

        public double DameCapacidadMilitar()
        {
            throw new NotImplementedException();
        }

        public double DamePrecio()
        {
            throw new NotImplementedException();
        }

        public double DameVelocidad()
        {
            throw new NotImplementedException();
        }
    }
}