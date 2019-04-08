using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public class Army
    {
        public int ID {get; set;}
        public string NombreEjercito {get; set;}
        public List<IDivision> Divisiones {get; set;}
        public void Add(IDivision miDivision)
        {

        }
    }
}