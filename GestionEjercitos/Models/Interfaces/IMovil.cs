using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public interface IMovil
    {
        double Velocidad { get; set; }

        void DameVelocidad();
    }
}