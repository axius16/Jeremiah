using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Rol
    {
        public Boolean habilitado { get; set; }
        public List<Funcion> funciones { get; set; }

        
    }
}
