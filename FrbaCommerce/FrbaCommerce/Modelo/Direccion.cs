using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    class Direccion
    {
        public String calle { set; get; }
        public Int32 numero { set; get; }
        public String piso { set; get; }
        public String departamento { set; get; }
        public String codigoPostal { set; get; }
        public String ciudad { set; get; }

        public Direccion(){}

        public Direccion(String calle, Int32 numero, String piso, String departamento, String codigoPostal, String ciudad) {
            this.calle = calle;
            this.numero = numero;
            this.piso = piso;
            this.departamento = departamento;
            this.codigoPostal = codigoPostal;
            this.ciudad = ciudad;
        }

    }
}
