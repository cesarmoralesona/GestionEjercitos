using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class Cañon : IArtilleria, IUnidad, IDestructor, IPreciable
    {
        private double potfuego;
        private double precioUnid;
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

        public IEjercito IEjercito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public double PotenciaDeFuego { get => potfuego; set => potfuego = value; }
        [Required]
        public double Precio { get => precioUnid; set => precioUnid = value; }

        public Division Division { get; set; }

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