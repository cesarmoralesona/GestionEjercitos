using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class TAXIN_66 : ICaballeria, IUnidad, IMovil, IPreciable
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreSanitario { get; set; }

        public IEjercito IEjercito { get; set; }
        [Required]
        public double Velocidad { get; set; }
        [Required]
        public double Precio { get; set; }

        public double DameCapacidadMilitar()
        {
            return CapacidadMilitar.DameCapacidadMilitar(0, Velocidad, 0);
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