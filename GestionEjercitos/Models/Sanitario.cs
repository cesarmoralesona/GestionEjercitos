﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ejercito
{
    public class Sanitario : IInfanteria, IMovil, IPreciable, IBlindado, IUnidad
    {
        public Sanitario(int iD, string nombreSanitario, double blindaje, double precio, double velocidad)
        {
            ID = iD;
            NombreSanitario = nombreSanitario ?? throw new ArgumentNullException(nameof(nombreSanitario));
            Blindaje = blindaje;
            Precio = precio;
            Velocidad = velocidad;
        }

        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreSanitario { get; set; }

        public IEjercito IEjercito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public double Blindaje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        double IMovil.Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Division Division { get; set; }

        public void DameBlindaje()
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