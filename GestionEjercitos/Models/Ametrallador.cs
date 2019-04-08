using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class Ametrallador : /*Ejercito.Division,*/ IInfanteria, IMovil, IDestructor, IPreciable, IUnidad
    {
        public Ametrallador(int iD, string nombre, double potenciaDeFuego, double precio, double velocidad)
        {
            ID = iD;
            NombreAmetrallador = nombre ?? throw new ArgumentNullException(nameof(nombre));
            PotenciaDeFuego = potenciaDeFuego;
            Precio = precio;
            Velocidad = velocidad;
        }

        public int ID { get; set; }
        public string NombreAmetrallador { get; set; }
        public IEjercito IEjercito { get ; set ; }
        public double PotenciaDeFuego { get; set; }
        public double Precio { get; set; }
        public double Velocidad { get ; set ; }

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