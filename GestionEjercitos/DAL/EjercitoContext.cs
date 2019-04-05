using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Ejercito;

namespace GestionEjercitos.DAL
{
    public class EjercitoContext : DbContext
    {
        public DbSet<Ametrallador> Ametralladoras { get; set; }
        public DbSet<Cañon> Cañones { get; set; }
        public DbSet<CañonAntiaereo> CañonAntiaereos {get; set;}
        public DbSet<Division> Divisiones {get; set;}
        public DbSet<Army> Ejercitos {get; set;}
        public DbSet<> {get; set;}

}
}