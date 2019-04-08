using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Migrations;
using Ejercito;

namespace GestionEjercitos.DAL
{
    public class EjercitoContext : DbContext
    {
        public EjercitoContext() : base("EjercitoContext")
        {
            Database.SetInitializer<EjercitoContext>(new DropCreateDatabaseAlways<EjercitoContext>());
        }
        public DbSet<Ametrallador> Ametralladoras { get; set; }
        public DbSet<Cañon> Cañones { get; set; }
        public DbSet<CañonAntiaereo> CañonAntiaereos {get; set;}
        public DbSet<Division> Divisiones {get; set;}
        public DbSet<Army> Ejercitos {get; set;}
        public DbSet<InfanteriaBasica>InfanteriasBasicas {get; set;}
        public DbSet<MX_7899> mX_7899s {get; set;}
        public DbSet<Sanitario> Sanitarios {get; set;}
        public DbSet<Sombras_VB98> Sombras_VB98s {get; set;}
        public DbSet<TAXIN_66> TAXIN_66s {get; set;}
        public DbSet<TorpederoMovil> TorpederoMoviles {get; set;}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}