﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class Sombras_VB98 : ICaballeria, IBlindado, IDestructor, IMovil, IPreciable, IUnidad
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreSombras_VB98 { get; set; }

        public IEjercito IEjercito { get; set; }
        [Required]
        public double Blindaje { get; set; }
        [Required]
        public double PotenciaDeFuego { get; set; }
        [Required]
        public double Velocidad { get; set; }
        [Required]
        public double Precio { get; set; }

        public double DameBlindaje()
        {
            return Blindaje;
        }

        public double DameCapacidadMilitar()
        {
            return CapacidadMilitar.DameCapacidadMilitar(PotenciaDeFuego, Velocidad, Blindaje);
        }

        public double DamePotenciaDeFuego()
        {
            return PotenciaDeFuego;
        }

        public double DamePrecio()
        {
            return Precio;
        }

        public double DameVelocidad()
        {
            return Velocidad;
        }
    }
}