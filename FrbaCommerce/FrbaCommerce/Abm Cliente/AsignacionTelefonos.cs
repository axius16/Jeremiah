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
/**/
namespace FrbaCommerce.Asignacion_Telefonos
{
    public partial class AsignacionTelefonos : Form
    {
        Cliente cliente;
        public AsignacionTelefonos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bAsignar_Click(object sender, EventArgs e)
        {
            DaoTelefono dao = new DaoTelefono();
            Int16 i = l_buscar.ToString();
            dao.validarTelefono();
            

            //validar si el telefono existe
            //si existe, mostrar el error en la label
            //si no exise, asignar a mi cliente
        }

        private void bDesasignar_Click(object sender, EventArgs e)
        {
            Telefono telefono = new Telefono();
            foreach (DataGridViewRow row in this.t_telefonos.SelectedRows)
            {
                telefono = row.DataBoundItem as Telefono;
            }
            DaoTelefono dao = new DaoTelefono();
            dao.desasignarTelefono(cliente, telefono);
            SQLUtils.SQLUtils.cargarTabla(this.t_telefonos, this.cliente.telefonos);
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setearCliente(Object unCliente)
        {
            if (unCliente != null)
            {
                this.cliente = (Cliente)unCliente;
                SQLUtils.SQLUtils.cargarTabla(this.t_telefonos, this.cliente.telefonos);
            }
        }
    }
}
