using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Visibilidad
    {
        public UInt32 codigo { get; set; }
        public String descripcion { get; set; }
        public Double precio { get; set; }
        public Byte porcentaje { get; set; }

        public Visibilidad(UInt32 codigo, String descripcion, Double precio, Byte porcentaje)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.porcentaje = porcentaje;
        }
    }
}
