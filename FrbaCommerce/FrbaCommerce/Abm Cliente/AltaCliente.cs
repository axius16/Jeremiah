using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FrbaCommerce.FrbaCommerce.Abm_Cliente
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        } 

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Modelo.Cliente cliente = new Modelo.Cliente();
            Modelo.Direccion direccion = new Modelo.Direccion();

            cliente.numeroDocumento = Convert.ToUInt32(l_numeroDocumento.Text);
            cliente.tipoDocumento = Convert.ToString(l_tipoDocumento.Text);
            cliente.nombre = Convert.ToString(l_nombre.Text);
            cliente.apellido = Convert.ToString(l_apellido.Text);
            cliente.mail = Convert.ToString(l_mail.Text);
            cliente.fechaNacimiento = Convert.ToDateTime(l_fechaNacimiento.Text);
            cliente.cuil = Convert.ToUInt32(l_cuil.Text);

            direccion.calle = Convert.ToString(l_calle.Text);
            direccion.numero = Convert.ToUInt32(l_numero.Text);
            direccion.piso = Convert.ToString(l_piso.Text);
            direccion.departamento = Convert.ToString(l_departamento.Text);
            direccion.ciudad = Convert.ToString(l_localidad.Text);
            direccion.codigoPostal = Convert.ToString(l_codigoPostal.Text);

            cliente.direccion = direccion;

            DAO.DaoCliente.persistir(cliente);            
        }

        private void bEditarTelefonos_Click(object sender, EventArgs e)
        {

        }    
    }
}
