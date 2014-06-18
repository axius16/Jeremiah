using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    class Usuario
    {
        public String nombreUsuario { get; set; }
        public String password { get; set; }
        public Boolean habilitado { get; set; }
        public List<Telefono> telefonos { get; set; }
        public List<Oferta> ofertas { get; set; }
        public List<Pregunta> preguntasRealizadas { get; set; }
        public List<Rol> roles { get; set; }
        public String tipoUsuario { get; set; }
        public List<Publicacion> publicaciones { get; set; }
        public List<Factura> facturasPagas { get; set; }

        public Usuario() { }

        public Usuario(String nombreUsuario, String password, Boolean habilitado, List<Telefono> telefonos,
                      List<Oferta> ofertas, List<Pregunta> preguntasRealizadas, List<Rol> roles, String tipoUsuario,
                        List<Publicacion> publicaciones, List<Factura> facturasPagas){
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.habilitado = habilitado;
            this.telefonos = telefonos;
            this.ofertas = ofertas;
            this.preguntasRealizadas = preguntasRealizadas;
            this.roles = roles;
            this.tipoUsuario = tipoUsuario;
            this.publicaciones = publicaciones;
            this.facturasPagas = facturasPagas;
        }


    }
}
