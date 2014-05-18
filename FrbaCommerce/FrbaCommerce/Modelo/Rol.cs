using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Rol
    {
        Boolean habilitado { get; set; }
        List<Funcion> funciones { get; set; }

        public Rol(Boolean habilitado, List<Funcion> funciones) {
            this.habilitado = habilitado;
            this.funciones = funciones;
        }
    }
}
