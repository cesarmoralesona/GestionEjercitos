using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Ejercito;

namespace GestionEjercitos.DAL
{
    public class EjercitoInitializer: System.Data.Entity.DropCreateDatabaseAlways<EjercitoContext>
    {
        protected override void Seed(EjercitoContext context)
        {
            InfanteriaBasica miInfanteria = new InfanteriaBasica { ID = 1, NombreInfanteriaBasica = "Los infantes del diablo", Velocidad = 6.0, PotenciaDeFuego = 7.0, Precio = 250.0 };
            context.InfanteriasBasicas.Add(miInfanteria);
            context.SaveChanges();

            Division miDivision = new Division { ID = 1, NombreDivision = "Infanteria" };
            context.Divisiones.Add(miDivision);
            context.SaveChanges();

            Army miEjercito = new Army { ID = 1, NombreEjercito = "Ejercito Español" };
            context.Ejercitos.Add(miEjercito);
            context.SaveChanges();
        }
    }
}