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

        public IEjercito IEjercito { get; set; }
        public double Velocidad { get; set; }
        public double Precio { get; set; }
        public double PotenciaDeFuego { get; set; }


        public double DameCapacidadMilitar()
        {
            return CapacidadMilitar.DameCapacidadMilitar(PotenciaDeFuego, Velocidad, 0);
        }

        public double DamePotenciaDeFuego()
        {
            return PotenciaDeFuego;
        }

        public double DamePrecio()
        {
            return Precio;
        }

        public double DameVelocidad()
        {
            return Velocidad;
        }

        
    }
}