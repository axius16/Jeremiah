using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Modelo
{
    class Cliente : Usuario
    {
        public Int32 idCliente { get; set; }
        public decimal numeroDocumento { get; set; }
        public String tipoDocumento { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String mail { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public Usuario usuario { get; set; }
        public String cuil { get; set; }
        public Direccion direccion { set; get; }

        public Cliente() { }


        public Cliente(String nombreUsuario, String password, Boolean habilitado, List<Telefono> telefonos,
                      List<Oferta> ofertas, List<Pregunta> preguntasRealizadas, List<Rol> roles, String tipoUsuario, Int16 numeroDocumento, String tipoDocumento, String nombre, String apellido,
                      String mail, DateTime fechaNacimiento, String cuil, Direccion direccion, List<Publicacion> publicaciones,
            List<Factura> facturasPagas)
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

            this.numeroDocumento = numeroDocumento;
            this.tipoDocumento = tipoDocumento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.fechaNacimiento = fechaNacimiento;
            this.cuil = cuil;
            this.direccion = direccion;
            
        }       


    }
}
