using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Telefono
    {
        Decimal numeroTelefono;

        public Telefono(Decimal numeroTelefono) {
            this.setTelefono(numeroTelefono);
        }

        public Decimal getTelefono() {
            return this.numeroTelefono;
        }

        public void setTelefono(Decimal numeroTelefono)
        {
            this.numeroTelefono = numeroTelefono;
        }


    }
}
