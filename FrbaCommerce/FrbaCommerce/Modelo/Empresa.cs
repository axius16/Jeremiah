using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Empresa : Usuario
    {
        String razonSocial { get; set; }
        String nombreContacto { get; set; }
        String mail { get; set; }
        DateTime fechaCreacion { get; set; }
        Usuario usuario { get; set; }
        UInt32 cuit { get; set; }
        Direccion direccion { set; get; }

        public Empresa(String nombreUsuario, String password, Boolean habilitado, List<Int16> telefonos, List<Oferta> ofertas, 
                        List<Pregunta> preguntasRealizadas, List<Rol> roles, String tipoUsuario, UInt32 numeroDocumento, String tipoDocumento, 
                        String razonSocial, String nombreContacto, String mail, DateTime fechaCreacion, UInt32 cuit, Direccion direccion,
                        List<Publicacion> publicaciones, List<Factura> facturasPagas)
        {
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

            this.razonSocial = razonSocial;
            this.nombreContacto = nombreContacto;
            this.mail = mail;
            this.fechaCreacion = fechaCreacion;
            this.cuit = cuit;
            this.direccion = direccion;
        }    
    }
}
