using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class InfanteriaBasica : /*Ejercito.Division,*/ IInfanteria, IPreciable, IDestructor, IMovil, IUnidad
    {
        public InfanteriaBasica(int iD, string nombreInfanteriaBasica, double precio, double potenciaDeFuego, double velocidad)
        {
            ID = iD;
            NombreInfanteriaBasica = nombreInfanteriaBasica ?? throw new ArgumentNullException(nameof(nombreInfanteriaBasica));
            Precio = precio;
            PotenciaDeFuego = potenciaDeFuego;
            Velocidad = velocidad;
        }

        [Required]
        public int ID { get; set; }
        [Required]     
        [MaxLength (50),MinLength (3)]
        public string NombreInfanteriaBasica { get; set; }

        public IEjercito IEjercito { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public double PotenciaDeFuego { get; set; }
        [Required]
        public double Velocidad { get; set; }

        public double DameCapacidadMilitar()
        {
            return CapacidadMilitar.DameCapacidadMilitar(PotenciaDeFuego, Velocidad, 0);
        }

        public Division Division { get; set; }

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