﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class TorpederoMovil : IArtilleria, IUnidad, IMovil, IDestructor, IBlindado, IPreciable
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreTorpederoMovil { get; set; }

        public IEjercito IEjercito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public double Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public double PotenciaDeFuego { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public double Blindaje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Division Division { get; set; }

        public void DameBlindaje()
        {
            throw new NotImplementedException();
        }

        public double DamePotenciaDeFuego()
        {
            throw new NotImplementedException();
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