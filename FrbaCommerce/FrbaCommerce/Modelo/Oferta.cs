using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    class Oferta
    {
        Publicacion publicacion { get; set; }
        Double monto { get; set; }
        DateTime fecha { get; set; }
        Boolean esMaxima { get; set; }

        public Oferta(Publicacion publicacion, Double monto, DateTime fecha, Boolean esMaxima ) {
            this.publicacion = publicacion;
            this.monto = monto;
            this.fecha = fecha;
            this.esMaxima = esMaxima;
        }
    }
}
