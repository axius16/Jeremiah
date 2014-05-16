using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.FrbaCommerce.Modelo;

namespace FrbaCommerce.FrbaCommerce.DAO
{
    class DaoCliente
    {
        public DaoCliente() { 
        }

        public Cliente getInstance(String nombre, String apellido, UInt32 numeroDocumento){
           return new Cliente(nombre, apellido, numeroDocumento);
        } 
        

    }
}
