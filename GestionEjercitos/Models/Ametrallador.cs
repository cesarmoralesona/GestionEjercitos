using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEjercitos
{
    public class Ametrallador : /*Ejercito.Division,*/ IInfanteria, IMovil, IDestructor, IPreciable, IUnidad
    {
        public int ID { get; set; }
        public string NombreAmetrallador { get; set; }


        public IEjercito IEjercito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double PotenciaDeFuego { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IMovil.Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DamePotenciaDeFuego()
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