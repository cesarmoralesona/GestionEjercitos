using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public interface IBlindado
    {
        double Blindaje { get; set; }

        double DameBlindaje();
        
    }
}