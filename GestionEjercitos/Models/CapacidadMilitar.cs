using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public static class CapacidadMilitar
    {
        public static double DameCapacidadMilitar(double Pf, double Cm, double Bl)
        {
            return ((Pf * (Cm / 2)) / 100 - Bl);
        }

       
    }
}