using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class Cañon : IArtilleria, IUnidad, IDestructor, IPreciable
    {
        
        public Cañon(int iD, string nombreCañon,  double potenciaDeFuego, double precio)
        {
            ID = iD;
            NombreCañon = nombreCañon ?? throw new ArgumentNullException(nameof(nombreCañon));
            //IEjercito = ejercito ?? throw new ArgumentNullException(nameof(ejercito));
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

        public double DamePotenciaDeFuego()
        {
            return PotenciaDeFuego;
        }

        public void DamePrecio()
        {
            throw new NotImplementedException();
        }

        
       
    }
}