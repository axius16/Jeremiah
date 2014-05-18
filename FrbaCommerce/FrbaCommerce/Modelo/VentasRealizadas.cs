using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class VentasRealizadas
    {
        Usuario usuarioComprador { get; set; }
        UInt32 cantidad { get; set; }
        DateTime fechaVenta { get; set; }
        String calificacion { get; set; }
        UInt16 cantidadEstrellas { get; set; }
        String comentarios { get; set; }
        Publicacion publicacion { get; set; }

        public VentasRealizadas(Usuario usuarioComprador, UInt32 cantidad, DateTime fechaVenta, String calificacion,
                                UInt16 cantidadEstrellas, String comentarios, Publicacion publicacion){
            this.usuarioComprador = usuarioComprador;
            this.cantidad = cantidad;
            this.fechaVenta = fechaVenta;
            this.calificacion = calificacion;
            this.cantidadEstrellas = cantidadEstrellas;
            this.comentarios = comentarios;
            this.publicacion = publicacion;
        }
    }
}
