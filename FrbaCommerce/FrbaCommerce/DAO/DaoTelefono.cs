using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.FrbaCommerce.Modelo;

namespace FrbaCommerce.FrbaCommerce.DAO
{
    class DaoTelefono
    {
        public DaoTelefono(){
        }

        public Telefono getInstance(Decimal numeroTelefono){
            return new Telefono(numeroTelefono);
        }
    }
}
