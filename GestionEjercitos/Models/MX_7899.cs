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

        public IEjercito IEjercito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public double Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public double Blindaje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
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