using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class Cañon : IArtilleria, IUnidad, IDestructor, IPreciable
    {
        
        public Cañon(int iD, string nombre,  double potenciaDeFuego, double precio)
        {
            ID = iD;
            NombreCañon = nombre ?? throw new ArgumentNullException(nameof(nombre));
            PotenciaDeFuego = potenciaDeFuego;
            Precio = precio;
        }

        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreCañon { get; set; }
        public IEjercito IEjercito { get; set ; }
        public double PotenciaDeFuego { get ; set ; }
        public double Precio { get; set; }

        public double DameCapacidadMilitar()
        {
            return CapacidadMilitar.DameCapacidadMilitar(PotenciaDeFuego, 0, 0);
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

        
       
    }
}