using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    class Rubro
    {
        UInt32 codigo { get; set; }
        String descripcion { get; set; }


        public Rubro(UInt32 codigo, String descripcion) {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }
    }
}
