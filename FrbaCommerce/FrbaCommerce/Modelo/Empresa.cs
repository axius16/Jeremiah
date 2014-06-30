using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    class Empresa : Usuario
    {
        public Decimal idEmpresa { get; set; }
        public String razonSocial { get; set; }
        public String nombreContacto { get; set; }
        public String mail { get; set; }
        public DateTime fechaCreacion { get; set; }
        public Usuario usuario { get; set; }
        public String cuit { get; set; }
        public Direccion direccion { set; get; }
        public List<Telefono> telefonos { set; get; }

        public Empresa() { 
        }    
    }
}
