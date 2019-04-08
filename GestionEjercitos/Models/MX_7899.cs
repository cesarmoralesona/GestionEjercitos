using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class MX_7899 : ICaballeria, IMovil, IBlindado, IPreciable, IUnidad
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreMX_7899 { get; set; }

        public IEjercito IEjercito { get; set; }
        [Required]
        public double Velocidad { get; set; }
        [Required]
        public double Blindaje { get; set; }
        [Required]
        public double Precio { get; set; }

        public double DameBlindaje()
        {
            return Blindaje;
        }

        public double DameCapacidadMilitar()
        {
            return CapacidadMilitar.DameCapacidadMilitar(0, Velocidad, Blindaje);
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