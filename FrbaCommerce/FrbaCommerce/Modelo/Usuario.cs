using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Usuario
    {
        public String nombreUsuario { get; set; }
        public String password { get; set; }
        public Boolean habilitado { get; set; }
        public List<Oferta> ofertas { get; set; }
        public List<Pregunta> preguntasRealizadas { get; set; }
        public List<Rol> roles { get; set; }
        public String tipoUsuario { get; set; }
        public List<Publicacion> publicaciones { get; set; }
        public List<Factura> facturasPagas { get; set; }
        public bool primerIngreso { get; set; }

        public Usuario() { }

        


        public List<Rol> getRolesActivos()
        {
            List<Rol> rolesActivos = new List<Rol>();

            rolesActivos = roles.FindAll(x => x.habilitado == true);
            
            return rolesActivos;
        }
    }
}
