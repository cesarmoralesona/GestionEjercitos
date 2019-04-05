using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    static class CapacidadMilitar 
    {
        private double Pf;
        private double Cm;
        private double Bl;

         static public double DameCapacidadMilitar(double Pf, double Cm, double Bl)
        {
            return ((Pf * (Cm / 2)) / 100 - Bl);
        }
    }
}