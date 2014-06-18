using System;
namespace FrbaCommerce.Modelo
{
    class Telefono
    {
        public Int32 idCliente { get; set; }
        public String numeroTelefono { get; set; }


        public Telefono(){}

        public Telefono(Int32 id_cliente, String numero_Telefono)
        {
            this.idCliente = id_cliente;
            this.numeroTelefono = numero_Telefono;    
        }
        
    }
}