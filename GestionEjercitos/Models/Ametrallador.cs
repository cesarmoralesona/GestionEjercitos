using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class Ametrallador : IInfanteria, IMovil, IDestructor, IPreciable, IUnidad
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreAmetrallador { get; set; }
        public IEjercito IEjercito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public double PotenciaDeFuego { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        double IMovil.Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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