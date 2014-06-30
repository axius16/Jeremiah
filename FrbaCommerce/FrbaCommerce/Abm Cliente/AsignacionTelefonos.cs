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

namespace FrbaCommerce.Asignacion_Telefonos
{
    public partial class AsignacionTelefonos : Form
    {
        Cliente cliente;
        Empresa empresa;
        
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
            Decimal numeroTelefono = Decimal.Parse(l_buscar.Text);
            
            bool telefonoDisponible = dao.validarTelefono(numeroTelefono);

            if (!telefonoDisponible) {
                l_estadoAsignacion.Text = "Telefono en uso!";
                return;
            }
            if (this.cliente == null)
            {
                dao.asignarTelefono(this.empresa, numeroTelefono);
            }
            else
            {
                dao.asignarTelefono(this.cliente, numeroTelefono);
            }
            l_estadoAsignacion.Text = "";
            actualizarTablaTelefonos();
        }

        private void actualizarTablaTelefonos()
        {
            if (cliente == null)
            {
                SQLUtils.SQLUtils.cargarTabla(this.t_telefonos, this.empresa.telefonos);
            }
            else
            {
                SQLUtils.SQLUtils.cargarTabla(this.t_telefonos, this.cliente.telefonos);

            }
        }

        private void bDesasignar_Click(object sender, EventArgs e)
        {
            Telefono telefono = new Telefono();
            foreach (DataGridViewRow row in this.t_telefonos.SelectedRows)
            {
                telefono = row.DataBoundItem as Telefono;
            }
            DaoTelefono dao = new DaoTelefono();
            if (cliente == null)
            {
                dao.desasignarTelefono(empresa, telefono);
            }
            else
            {
                dao.desasignarTelefono(cliente, telefono);
            }
            this.actualizarTablaTelefonos();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setearCliente(Object unCliente)
        {
            if (unCliente != null)
            {
                this.empresa = null;
                this.cliente = (Cliente)unCliente;
                this.l_estadoAsignacion.Text = "";
                this.actualizarTablaTelefonos();
            }
        }
        public void setearEmpresa(Object unaEmpresa)
        {
            if (unaEmpresa != null)
            {
                this.cliente = null;
                this.empresa = (Empresa)unaEmpresa;
                this.l_estadoAsignacion.Text = "";
                this.actualizarTablaTelefonos();
            }
        }
    }
}
