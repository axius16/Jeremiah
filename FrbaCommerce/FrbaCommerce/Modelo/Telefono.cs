using System;
namespace FrbaCommerce.Modelo
{
    class Telefono
    {
        public Decimal idCliente { get; set; }
        public Decimal idEmpresa { get; set; }
        public Decimal numeroTelefono { get; set; }


        public Telefono(){}

        public Telefono(Cliente cliente, Decimal numero_Telefono)
        {
            this.idCliente = cliente.idCliente;
            this.numeroTelefono = numero_Telefono;    
        }

        public Telefono(Empresa empresa, Decimal numero_Telefono)
        {
            this.idEmpresa = empresa.idEmpresa;
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