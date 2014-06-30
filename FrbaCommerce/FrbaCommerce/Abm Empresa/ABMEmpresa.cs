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

namespace FrbaCommerce.Abm_Empresa
{
    public partial class AbmEmpresa : Form
    {
        public AbmEmpresa()
        {
            InitializeComponent();
                      
        }

        private void AbmEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void bAlta_Click(object sender, EventArgs e)
        {
            AltaEmpresa ventana = new AltaEmpresa();
            ventana.ShowDialog();
            this.Limpiar_Click(sender, e);
        }

        private void bModificacion_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            foreach (DataGridViewRow row in this.tb_empresas.SelectedRows)
            {
                empresa = row.DataBoundItem as Empresa;
            }
            if (empresa.idEmpresa == 0)
            {
                MessageBox.Show("Por favor seleccione una Empresa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AltaEmpresa ventana = new AltaEmpresa();
            ventana.setearEmpresa(empresa);
            ventana.ShowDialog();
            this.Buscar_Click(sender, e);
        }

        
        private void bBaja_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Clic en Eliminar");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String razonSocial = Convert.ToString(l_RazonSocial.Text);
            String eMail = Convert.ToString(l_eMail.Text);
            String cuit = Convert.ToString(l_CUIT.Text);
            SQLUtils.SQLUtils.cargarTabla(this.tb_empresas, DaoEmpresa.getEmpresas(razonSocial, eMail, cuit));
        
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.l_RazonSocial.Text = "";
            this.l_eMail.Text = "";
            this.l_CUIT.Text = "";
            this.tb_empresas.DataSource = null;
            this.tb_empresas.Refresh();
        }
    }
}
