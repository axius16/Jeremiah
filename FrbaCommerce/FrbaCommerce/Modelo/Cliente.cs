using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Cliente : Usuario
    {
        UInt32 numeroDocumento { get; set; }
        String tipoDocumento { get; set; }
        String nombre { get; set; }
        String apellido { get; set; }
        String mail { get; set; }
        DateTime fechaNacimiento { get; set; }
        Usuario usuario { get; set; }
        UInt32 cuil { get; set; }
        Direccion direccion { set; get; }

        public Cliente(String nombreUsuario, String password, Boolean habilitado, List<UInt16> telefonos,
                      List<Oferta> ofertas, List<Pregunta> preguntasRealizadas, List<Rol> roles, String tipoUsuario, UInt32 numeroDocumento, String tipoDocumento, String nombre, String apellido,
                      String mail, DateTime fechaNacimiento, UInt32 cuil, Direccion direccion)
        {
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.habilitado = habilitado;
            this.telefonos = telefonos;
            this.ofertas = ofertas;
            this.preguntasRealizadas = preguntasRealizadas;
            this.roles = roles;
            this.tipoUsuario = tipoUsuario;

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
