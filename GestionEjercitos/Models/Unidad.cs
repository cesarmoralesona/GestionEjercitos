using Ejercito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEjercitos.Models
{
    /// <summary>
    /// factory
    /// </summary>
    abstract class Unidad
    {
        public abstract InfanteriaBasica CrearInfanteriaBasica();
        public abstract Ametrallador CrearAmetrallador();
        public abstract Sanitario CrearSanitario();
        
    }
}