using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;
using FrbaCommerce.Asignacion_Telefonos;
using FrbaCommerce.DAO;


namespace FrbaCommerce.Abm_Cliente
{
    public partial class AltaCliente : Form
    {
        Cliente cliente;
       
        public AltaCliente()
        {
            InitializeComponent();
            this.l_tipoDocumento.DataSource = DaoTipoDocumento.getAll();
            this.l_tipoDocumento.DisplayMember = "descTipoDocumento";
            this.l_tipoDocumento.ValueMember = "idTipoDocumento";
        }

        public void setearCliente(Object unCliente)
        {
            if (unCliente != null)
            {
                this.cliente = (Cliente)unCliente;
                this.l_apellido.Text = cliente.apellido;
                this.l_nombre.Text = cliente.nombre;
                this.l_mail.Text = cliente.mail;
                this.l_numeroDocumento.Text = cliente.numeroDocumento.ToString();
                this.l_fechaNacimiento.Text = cliente.fechaNacimiento.ToString("d");
                this.l_telefonos.DataSource = cliente.telefonos;
                this.l_cuil.Text = cliente.cuil;
                this.l_tipoDocumento.Text = cliente.tipoDocumento.descTipoDocumento;
                this.l_calle.Text = cliente.direccion.calle;
                this.l_localidad.Text = cliente.direccion.ciudad;
                this.l_codigoPostal.Text = cliente.direccion.codigoPostal;
                this.l_departamento.Text = cliente.direccion.departamento;
                Decimal aux = cliente.direccion.numero;
                String miNumero = "";
                if (aux != 0)
                {
                    miNumero = cliente.direccion.numero.ToString();
                }                
                this.l_numero.Text = miNumero;
                this.l_piso.Text = cliente.direccion.piso;
            }
        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Modelo.Direccion direccion = new Modelo.Direccion();
            cliente.numeroDocumento = Convert.ToDecimal(l_numeroDocumento.Text);
            cliente.tipoDocumento = (TipoDocumento)l_tipoDocumento.SelectedItem;
            cliente.nombre = Convert.ToString(l_nombre.Text);
            cliente.apellido = Convert.ToString(l_apellido.Text);
            cliente.mail = Convert.ToString(l_mail.Text);
            cliente.fechaNacimiento = Convert.ToDateTime(l_fechaNacimiento.Text);
            cliente.cuil = Convert.ToString(l_cuil.Text);

            if (l_numero.Text == "")
            {
                direccion.numero = 0;
            }
            else {
                direccion.numero = Convert.ToInt32(l_numero.Text);
            }

            direccion.calle = Convert.ToString(l_calle.Text);
            direccion.piso = Convert.ToString(l_piso.Text);
            direccion.departamento = Convert.ToString(l_departamento.Text);
            direccion.ciudad = Convert.ToString(l_localidad.Text);
            direccion.codigoPostal = Convert.ToString(l_codigoPostal.Text);

            cliente.direccion = direccion;

            DAO.DaoCliente.persistir(cliente);
            this.Dispose();
        }

        public void bEditarTelefonos_Click(object sender, EventArgs e)
        {
            AsignacionTelefonos ventana = new AsignacionTelefonos();
            ventana.setearCliente(cliente);
            ventana.ShowDialog();
            this.l_telefonos.DataSource = null;
            cliente.telefonos = new DaoTelefono().getTelefonos(cliente);
            this.l_telefonos.DataSource = cliente.telefonos;
            this.l_telefonos.Refresh();
        }
    }
}
