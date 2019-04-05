using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public class CañonAntiaereo : IArtilleria, IUnidad, IMovil, IPreciable, IDestructor
    {
        public int ID { get; set; }
        public string NombreCañonAntiaereo { get; set; }

        public IEjercito IEjercito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double PotenciaDeFuego { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       

        public double DamePotenciaDeFuego()
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

        double IDestructor.DamePotenciaDeFuego()
        {
            throw new NotImplementedException();
        }
    }
}