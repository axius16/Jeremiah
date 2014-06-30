using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Publicacion
    {
        public UInt32 codigo { get; set; }
        public String codigoPublicacion { get; set; }
        public UInt32 stock { get; set; }
        public Double precio { get; set; }
        public String descripcion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public Boolean preguntasActivas { get; set; }
        public List<Rubro> rubros { get; set; }
        public String estado { get; set; }
        public Visibilidad visibilidad { get; set; }
        public Usuario vendedor { get; set; }

        public Publicacion(UInt32 codigo, String codiogoPublicacion, UInt32 stock, Double precio, String descripcion, DateTime fechaInicio,
                           DateTime fechaVencimiento, Boolean preguntasActivas, List<Rubro> rubros, String estado, Visibilidad visibilidad,
            Usuario vendedor)
        {
            this.codigo = codigo;
            this.codigoPublicacion = codiogoPublicacion;
            this.stock = stock;
            this.precio = precio;
            this.descripcion = descripcion;
            this.fechaInicio = fechaInicio;
            this.fechaVencimiento = fechaVencimiento;
            this.preguntasActivas = preguntasActivas;
            this.rubros = rubros;
            this.estado = estado;
            this.visibilidad = visibilidad;
            this.vendedor = vendedor;
        }
    }
}
