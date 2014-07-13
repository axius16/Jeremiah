using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Rol
    {
        public Decimal idRol { get; set; }
        public Decimal idEstado { get; set; }
        public String descipcion { get; set; }
        public Boolean habilitado { get; set; }
        public List<Funcionalidad> funciones { get; set; }

        
    }
}
