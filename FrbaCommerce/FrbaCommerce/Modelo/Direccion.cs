using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Direccion
    {
        String calle { set; get; }
        UInt32 numero { set; get; }
        String piso { set; get; }
        String departamento { set; get; }
        String codigoPostal { set; get; }
        String ciudad { set; get; }

        public Direccion(String calle, UInt32 numero, String piso, String departamento, String codigoPostal, String ciudad) {
            this.calle = calle;
            this.numero = numero;
            this.piso = piso;
            this.departamento = departamento;
            this.codigoPostal = codigoPostal;
            this.ciudad = ciudad;
        }

    }
}
