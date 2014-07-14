using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Publicacion
    {
        public Decimal idPublicacion { get; set; }
        public String codigoPublicacion { get; set; }
        public Decimal stock { get; set; }
        public Decimal precio { get; set; }
        public String descripcion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public Boolean preguntasActivas { get; set; }
        public Boolean flagBonificada { get; set; }
        public Boolean flagRendida { get; set; }
        public List<Rubro> rubros { get; set; }
        public EstadoPublicacion estado { get; set; }
        public Visibilidad visibilidad { get; set; }
        public TipoPublicacion tipoPublicacion { get; set; }
        public Usuario vendedor { get; set; }

        public Publicacion(){}
    }
}
