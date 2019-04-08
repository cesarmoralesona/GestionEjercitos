using Ejercito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEjercitos.Models
{
    class InfanteriaFactory : Unidad
    {
        public override Ametrallador CrearAmetrallador()
        {
            return new Ametrallador(1,"Ametrallador",10,400,4);
        }

        public override InfanteriaBasica CrearInfanteriaBasica()
        {
            return new InfanteriaBasica (1,"Infanteria Basica", 7,250,6);
        }

        public override Sanitario CrearSanitario()
        {
            return new Sanitario (1,"Sanitario", 500,7,5);
        }
    }
}