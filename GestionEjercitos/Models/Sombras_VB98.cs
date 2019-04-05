using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public class Sombras_VB98 : ICaballeria, IBlindado, IDestructor, IMovil, IPreciable, IUnidad
    {
        public int ID { get; set; }
        public string NombreSombras_VB98 { get; set; }

        public IEjercito IEjercito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Blindaje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double PotenciaDeFuego { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DameBlindaje()
        {
            throw new NotImplementedException();
        }

        public double DameCapacidadMilitar()
        {
            throw new NotImplementedException();
        }

        public double DamePotenciaDeFuego()
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