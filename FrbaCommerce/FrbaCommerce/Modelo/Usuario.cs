﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Usuario
    {
        protected String nombreUsuario { get; set; }
        protected String password { get; set; }
        protected Boolean habilitado { get; set; }
        protected List<UInt16> telefonos { get; set; }
        protected List<Oferta> ofertas { get; set; }
        protected List<Pregunta> preguntasRealizadas { get; set; }
        protected List<Rol> roles { get; set; }
        protected String tipoUsuario { get; set; }

        public Usuario() { }

        public Usuario(String nombreUsuario, String password, Boolean habilitado, List<UInt16> telefonos,
                      List<Oferta> ofertas, List<Pregunta> preguntasRealizadas, List<Rol> roles, String tipoUsuario){
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.habilitado = habilitado;
            this.telefonos = telefonos;
            this.ofertas = ofertas;
            this.preguntasRealizadas = preguntasRealizadas;
            this.roles = roles;
            this.tipoUsuario = tipoUsuario;
        }


    }
}
