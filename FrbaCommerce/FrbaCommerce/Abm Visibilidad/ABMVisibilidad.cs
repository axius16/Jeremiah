using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.DAO;
using FrbaCommerce.Abm_Empresa;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class AbmVisibilidad : Form
    {
        public AbmVisibilidad()
        {
            InitializeComponent();                      
        }

        private void AbmEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void bAlta_Click(object sender, EventArgs e)
        {
            AltaVisibilidad ventana = new AltaVisibilidad();
            ventana.ShowDialog();
            this.Limpiar_Click(sender, e);
        }

        private void bModificacion_Click(object sender, EventArgs e)
        {
            Visibilidad visibilidad = new Visibilidad();
            foreach (DataGridViewRow row in this.tb_visibilidades.SelectedRows)
            {
                visibilidad = row.DataBoundItem as Visibilidad;
            }
            if (visibilidad.idVisibilidad == 0)
            {
                MessageBox.Show("Por favor seleccione una Empresa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AltaEmpresa ventana = new AltaEmpresa();
            ventana.setearEmpresa(visibilidad);
            ventana.ShowDialog();
            this.Buscar_Click(sender, e);
        }

        
        private void bBaja_Click(object sender, EventArgs e)
        {
            Visibilidad visibilidad = new Visibilidad();
            foreach (DataGridViewRow row in this.tb_visibilidades.SelectedRows)
            {
                visibilidad = row.DataBoundItem as Visibilidad;
            }
            if (visibilidad.idVisibilidad == 0)
            {
                MessageBox.Show("Por favor seleccione una Vibilidad.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DaoVisibilidad.eliminar(visibilidad);
            this.Buscar_Click(sender, e);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String codigo = Convert.ToString(t_codigo.Text);
            String descripcion = Convert.ToString(t_descripcion.Text);
            SQLUtils.SQLUtils.cargarTabla(this.tb_visibilidades, DaoVisibilidad.getVisibilidades(codigo, descripcion));
        
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.t_codigo.Text = "";
            this.t_descripcion.Text = "";
            this.tb_visibilidades.DataSource = null;
            this.tb_visibilidades.Refresh();
        }
    }
}
