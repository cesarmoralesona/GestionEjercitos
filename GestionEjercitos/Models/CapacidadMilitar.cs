using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    static class CapacidadMilitar
    {
         CapacidadMilitar(double Pf, double Cm, double Bl)
       

        //private double Pf;
        //private double Cm;
        //private double Bl;

         static public double DameCapacidadMilitar()
        {
            return ((Pf * (Cm / 2)) / 100 - Bl);
        }
    }
}