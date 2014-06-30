using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class VentasRealizadas
    {
        public Usuario usuarioComprador { get; set; }
        public UInt32 cantidad { get; set; }
        public DateTime fechaVenta { get; set; }
        public String calificacion { get; set; }
        public UInt16 cantidadEstrellas { get; set; }
        public String comentarios { get; set; }
        public Publicacion publicacion { get; set; }

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
