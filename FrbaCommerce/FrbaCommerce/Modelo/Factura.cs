using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Factura
    {
        UInt32 numeroFactura { get; set; }
        String modoDePago { get; set; }
        DateTime fechaPago { get; set; }
        UInt32 monto { get; set; }
        List<VentasRealizadas> ventasPagadas { get; set; }
        Usuario usuario { get; set; }

        public Factura(UInt32 numeroFactura, String modoDePago, DateTime fechaPago, UInt32 monto, 
            List<VentasRealizadas> ventasPagadas, Usuario usaurio) {
            this.numeroFactura = numeroFactura;
            this.modoDePago = modoDePago;
            this.fechaPago = fechaPago;
            this.monto = monto;
            this.ventasPagadas = ventasPagadas;
            this.usuario = usuario;


        }
    }
}
