﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public interface IPreciable
    {
        double Precio { get; set; }

        double DamePrecio();
    }
}