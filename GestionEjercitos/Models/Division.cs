using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public class Division
    {
        public int ID {get; set;}
        public string NombreDivision {get; set;}
        public List<IUnidad> Unidades = new List<IUnidad>();
        public Army Ejercito { get; set; }
        public void Add(IUnidad miUnidad)
        {

        }
        public void Edit(IUnidad miUnidad)
        {

        }
        public void Delete(IUnidad miUnidad)
        {

        }

    }
}