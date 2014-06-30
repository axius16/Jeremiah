using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Factura
    {
        public UInt32 numeroFactura { get; set; }
        public String modoDePago { get; set; }
        public DateTime fechaPago { get; set; }
        public UInt32 monto { get; set; }
        public List<VentasRealizadas> ventasPagadas { get; set; }
        public Usuario usuario { get; set; }

        
    }
}
