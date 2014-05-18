using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Visibilidad
    {
        UInt32 codigo { get; set; }
        String descripcion { get; set; }
        Double precio { get; set; }
        Byte porcentaje { get; set; }

        public Visibilidad(UInt32 codigo, String descripcion, Double precio, Byte porcentaje)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.porcentaje = porcentaje;
        }
    }
}
