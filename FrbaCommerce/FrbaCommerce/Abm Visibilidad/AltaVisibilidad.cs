using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;
using FrbaCommerce.DAO;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class AltaVisibilidad : Form
    {
        Visibilidad visibilidad{get; set;}
        
        public AltaVisibilidad()
        {
            InitializeComponent();
        }

        public void setearVisibilidad(Object unaVisibilidad)
        {
            if (this.visibilidad == null)
            {
                this.visibilidad = (Visibilidad)unaVisibilidad;
                this.t_descripcion.Text = this.visibilidad.descripcion;

                String codigo;
                try { codigo = this.visibilidad.codigo.ToString(); }
                catch { codigo = ""; }
                this.t_codigo.Text = codigo;

                String dias;
                try { dias = this.visibilidad.cantidadDias.ToString(); }
                catch { dias = ""; }
                this.t_duracion.Text = dias;

                String porcentaje;
                try { porcentaje = this.visibilidad.cantidadDias.ToString(); }
                catch { porcentaje = ""; }
                this.t_porcentajeVenta.Text = porcentaje;
                
                String precioPublicacion;
                try { precioPublicacion = this.visibilidad.cantidadDias.ToString(); }
                catch { precioPublicacion = ""; }
                this.t_precioPorPublicar.Text = precioPublicacion;
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            visibilidad.codigo = Convert.ToDecimal(t_codigo.Text);
            visibilidad.descripcion = Convert.ToString(t_descripcion.Text);
            visibilidad.cantidadDias= Convert.ToDecimal(t_duracion.Text);
            visibilidad.porcentaje = Convert.ToDecimal(t_porcentajeVenta.Text);
            visibilidad.precio = Convert.ToDecimal(t_precioPorPublicar.Text);

            DaoVisibilidad.persistir(visibilidad);
            this.Dispose();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      
    }
}
