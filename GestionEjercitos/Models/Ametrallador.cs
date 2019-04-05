﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class Ametrallador : /*Ejercito.Division,*/ IInfanteria, IMovil, IDestructor, IPreciable, IUnidad
    {
        public Ametrallador(int iD, string nombreAmetrallador, IEjercito ejercito, double potenciaDeFuego, double precio, double velocidad)
        {
            ID = iD;
            NombreAmetrallador = nombreAmetrallador ?? throw new ArgumentNullException(nameof(nombreAmetrallador));
            IEjercito = ejercito ?? throw new ArgumentNullException(nameof(ejercito));
            PotenciaDeFuego = potenciaDeFuego;
            Precio = precio;
            Velocidad = velocidad;
        }

        public int ID { get; set; }
        public string NombreAmetrallador { get; set; }
        public IEjercito IEjercito { get ; set ; }
        public double PotenciaDeFuego { get; set; }
        public double Precio { get; set; }
        public double Velocidad { get ; set ; }

        public double DameCapacidadMilitar()
        {
            throw new NotImplementedException();
        }

        public double DamePotenciaDeFuego()
        {
            return PotenciaDeFuego;
        }

        public void DamePrecio()
        {
            throw new NotImplementedException();
        }

        public void DameVelocidad()
        {
            throw new NotImplementedException();
        }
    }
}