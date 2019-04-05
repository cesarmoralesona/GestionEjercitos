using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public class Cañon : IArtilleria, IUnidad, IDestructor, IPreciable
    {
        
        public Cañon(int iD, string nombreCañon,  double potenciaDeFuego, double precio)
        {
            ID = iD;
            NombreCañon = nombreCañon ?? throw new ArgumentNullException(nameof(nombreCañon));
            PotenciaDeFuego = potenciaDeFuego;
            Precio = precio;
        }

        public int ID { get; set; }
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

        public double DamePrecio()
        {
            throw new NotImplementedException();
        }

        
       
    }
}