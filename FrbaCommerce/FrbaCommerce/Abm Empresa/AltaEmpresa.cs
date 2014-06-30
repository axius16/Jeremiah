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
using FrbaCommerce.Asignacion_Telefonos;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class AltaEmpresa : Form
    {
        Empresa empresa;
        public AltaEmpresa()
        {
            InitializeComponent();
        } 

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setearEmpresa(Object unaEmpresa)
        {
            if (unaEmpresa != null)
            {
                this.empresa = (Empresa)unaEmpresa;
                this.l_razonSocial.Text = empresa.razonSocial;
                this.l_nombreContacto.Text = empresa.nombreContacto;
                this.l_mail.Text = empresa.mail;
                this.l_fechaCreacion.Text = empresa.fechaCreacion.ToString("d");
                this.l_cuit.Text = empresa.cuit;
                this.l_calle.Text = empresa.direccion.calle;
                this.l_localidad.Text = empresa.direccion.ciudad;
                this.l_codigoPostal.Text = empresa.direccion.codigoPostal;
                this.l_departamento.Text = empresa.direccion.departamento;
                Decimal aux = empresa.direccion.numero;
                String miNumero = "";
                if (aux != 0)
                {
                    miNumero = empresa.direccion.numero.ToString();
                }
                this.l_numero.Text = miNumero;
                this.l_piso.Text = empresa.direccion.piso;
            }
        }


        private void Aceptar_Click(object sender, EventArgs e)
        {
            Direccion direccion = new Direccion();

            empresa.razonSocial = Convert.ToString(l_razonSocial.Text);
            empresa.nombreContacto = Convert.ToString(l_nombreContacto.Text);
            empresa.mail = Convert.ToString(l_mail.Text);
            empresa.fechaCreacion = Convert.ToDateTime(l_fechaCreacion.Text);
            empresa.cuit = Convert.ToString(l_cuit.Text);

            direccion.calle = Convert.ToString(l_calle.Text);
            direccion.numero = Convert.ToInt32(l_numero.Text);
            direccion.piso = Convert.ToString(l_piso.Text);
            direccion.departamento = Convert.ToString(l_departamento.Text);
            direccion.ciudad = Convert.ToString(l_localidad.Text);
            direccion.codigoPostal = Convert.ToString(l_codigoPostal.Text);

            empresa.direccion = direccion;

            DaoEmpresa.persistir(empresa);
            this.Dispose();
        }

        private void EditarTelefonos_Click(object sender, EventArgs e)
        {
            AsignacionTelefonos ventana = new AsignacionTelefonos();
            ventana.setearEmpresa(empresa);
            ventana.ShowDialog();
            this.l_telefonos.DataSource = null;
            empresa.telefonos = new DaoTelefono().getTelefonos(empresa);
            this.l_telefonos.DataSource = empresa.telefonos;
            this.l_telefonos.Refresh();
        }    
    }
}
