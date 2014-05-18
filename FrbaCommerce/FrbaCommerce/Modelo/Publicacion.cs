using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Publicacion
    {
        UInt32 codigo { get; set; }
        String codiogoPublicacion { get; set; }
        UInt32 stock { get; set; }
        Double precio { get; set; }
        String descripcion { get; set; }
        DateTime fechaInicio { get; set; }
        DateTime fechaVencimiento { get; set; }
        Boolean preguntasActivas { get; set; }
        List<Rubro> rubros { get; set; }
        String estado { get; set; }
        Visibilidad visibilidad { get; set; }

        public Publicacion(UInt32 codigo, String codiogoPublicacion, UInt32 stock, Double precio, String descripcion, DateTime fechaInicio,
                           DateTime fechaVencimiento, Boolean preguntasActivas, List<Rubro> rubros, String estado, Visibilidad visibilidad)
        {
            this.codigo = codigo;
            this.codiogoPublicacion = codiogoPublicacion;
            this.stock = stock;
            this.precio = precio;
            this.descripcion = descripcion;
            this.fechaInicio = fechaInicio;
            this.fechaVencimiento = fechaVencimiento;
            this.preguntasActivas = preguntasActivas;
            this.rubros = rubros;
            this.estado = estado;
            this.visibilidad = visibilidad;
        }
    }
}
