﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FSVentas3.Models
{
    public class CotizacionesDetalles
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public int CotizacionId { get; set; }
        public int ArticuloId { get; set; }

        public virtual Articulos Articulos { get; set; }
        public virtual Cotizaciones Cotizaciones { get; set; } //Uno

        public CotizacionesDetalles()
        {
            Articulos = new Articulos();
        }

        public CotizacionesDetalles(int articuloId, string descripcion, int cantidad, double precio )
        {
            this.Descripcion = descripcion;
            this.ArticuloId= ArticuloId;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }
    }
}
