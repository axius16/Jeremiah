using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Cliente
    {
        UInt32 numeroDocumento  { get; set; }
        String tipoDocumento { get; set; }
        String nombre { get; set; }
        String apellido { get; set; }
        String mail { get; set; }

        String calle { get; set; }
        UInt32 numero { get; set; }
        String piso { get; set; }
        String depto { get; set; }

        UInt32 codigoPostal { get; set; }
        DateTime fechaNacimiento { get; set; }
        String username { get; set; }
        UInt32 cuil { get; set; }

        Telefono[] telefonos;
               

        public Cliente(String nombre, String apellido, UInt32 numeroDocumento) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroDocumento = numeroDocumento;
        }       

       
    }
}
