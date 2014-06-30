using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Oferta
    {
        Publicacion publicacion { get; set; }
        Double monto { get; set; }
        DateTime fecha { get; set; }
        Boolean esMaxima { get; set; }

        
    }
}
