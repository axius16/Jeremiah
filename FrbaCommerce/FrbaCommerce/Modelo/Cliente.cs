using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Modelo
{
    class Cliente : Usuario
    {
        public Decimal idCliente { get; set; }
        public Decimal numeroDocumento { get; set; }
        public TipoDocumento tipoDocumento { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String mail { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public Usuario usuario { get; set; }
        public String cuil { get; set; }
        public Direccion direccion { set; get; }
        public List<Telefono> telefonos { set; get; }

        public Cliente() { }
        
    }
}
