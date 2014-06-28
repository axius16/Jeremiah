using System;
namespace FrbaCommerce.Modelo
{
    class Telefono
    {
        public Int32 idCliente { get; set; }
        public Decimal numeroTelefono { get; set; }


        public Telefono(){}

        public Telefono(Int32 id_cliente, Decimal numero_Telefono)
        {
            this.idCliente = id_cliente;
            this.numeroTelefono = numero_Telefono;    
        }

        
        override public String ToString(){
            try
            {
                return this.numeroTelefono.ToString();
            }
            catch(Exception ex){
                return "";
            }
        }
        
    }
}