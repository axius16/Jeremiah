using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;
using FrbaCommerce.ABM_Rol;
using FrbaCommerce.DAO;

namespace FrbaCommerce.Abm_Rol
{
    public partial class ABMRol : Form
    {
        public ABMRol()
        {
            InitializeComponent();
        }

        public static void comboBoxFuncionalidades(ComboBox cmbFuncionalidad)
        {
            List<Funcionalidad> lista = DaoFuncionalidad.getAllFuncionalidades();
            cmbFuncionalidad.DataSource = lista;
            cmbFuncionalidad.DisplayMember = "funcionalidad";
            cmbFuncionalidad.ValueMember = "id";
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            String rol = Convert.ToString(l_rol.Text);
            SQLUtils.SQLUtils.cargarTabla(this.tb_roles, DaoRol.getRoles(rol));
        
        }

        private void bModificacion_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            foreach (DataGridViewRow row in this.tb_roles.SelectedRows)
            {
                rol = row.DataBoundItem as Rol;
            }
            if (rol.idRol == 0)
            {
                MessageBox.Show("Por favor seleccione un Rol.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AltaRol ventana = new AltaRol();
            ventana.setearRol(rol);
            ventana.ShowDialog();
            this.bBuscar_Click(sender, e);
        }
                
        private void bAlta_Click(object sender, EventArgs e)
        {
            AltaRol ventana = new AltaRol();
            ventana.ShowDialog();
            this.bBuscar_Click(sender, e);
        }

           
    }
}
