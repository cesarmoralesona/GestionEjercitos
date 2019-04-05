using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
   
    public interface IDestructor
    {
        double PotenciaDeFuego { get; set; }

        void DamePotenciaDeFuego();
    }
}