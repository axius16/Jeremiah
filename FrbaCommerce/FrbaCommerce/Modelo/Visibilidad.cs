using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Visibilidad
    {
        public Decimal idVisibilidad { get; set; }
        public Decimal codigo { get; set; }
        public String descripcion { get; set; }
        public Decimal precio { get; set; }
        public Decimal porcentaje { get; set; }
        public Decimal cantidadDias { get; set; }

        public Visibilidad() { }
    }
}
