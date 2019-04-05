using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEjercitos
{
    public interface IBlindado
    {
        double Blindaje { get; set; }

        void DameBlindaje();
    }
}