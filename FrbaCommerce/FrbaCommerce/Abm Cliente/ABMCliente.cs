using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce;
using FrbaCommerce.SQLUtils;
using FrbaCommerce.Modelo;
using FrbaCommerce.DAO;
/**/
namespace FrbaCommerce.Abm_Cliente
{
    public partial class ABMCliente : Form
    {           
        

        public ABMCliente()
        {
            InitializeComponent();
            TipoDocumento tipoDoc = new TipoDocumento();
            tipoDoc.descTipoDocumento = "Indistinto";
            List<TipoDocumento> tiposDocumento = new List<TipoDocumento>();
            tiposDocumento.Add(tipoDoc);
            tiposDocumento.AddRange(DaoTipoDocumento.getAll());            
            this.l_TipoDocumento.DataSource = tiposDocumento;
            this.l_TipoDocumento.DisplayMember = "descTipoDocumento";
            this.l_TipoDocumento.ValueMember = "idTipoDocumento";
            this.l_TipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bAlta_Click(object sender, EventArgs e)
        {
            AltaCliente ventana = new AltaCliente();
            ventana.ShowDialog();
            this.Limpiar_Click(sender, e);
        }

        private void bModificacion_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            foreach (DataGridViewRow row in this.t_clientes.SelectedRows)
            {
                cliente = row.DataBoundItem as Cliente;
            }
            if(cliente.idCliente == 0){
                MessageBox.Show("Por favor seleccione un Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            AltaCliente ventana = new AltaCliente();
            ventana.setearCliente(cliente);
            ventana.ShowDialog();
            this.Buscar_Click(sender, e);
        }

        
        
        private void bBaja_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            foreach (DataGridViewRow row in this.t_clientes.SelectedRows)
            {
                cliente = row.DataBoundItem as Cliente;
            }
            if (cliente.idCliente == 0)
            {
                MessageBox.Show("Por favor seleccione un Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DAO.DaoCliente.eliminar(cliente);
            this.Buscar_Click(sender, e);
        
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String numeroDocumento = Convert.ToString(l_NumeroDocumento.Text);
            TipoDocumento tipoDocumento = (TipoDocumento)l_TipoDocumento.SelectedItem;
            String nombre = Convert.ToString(l_Nombre.Text);
            String apellido = Convert.ToString(l_Apellido.Text);
            String mail = Convert.ToString(l_eMail.Text);

            SQLUtils.SQLUtils.cargarTabla(this.t_clientes, DAO.DaoCliente.getClientes(apellido, nombre, numeroDocumento, tipoDocumento, mail));
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.l_NumeroDocumento.Text = "";
            this.l_TipoDocumento.Refresh();
            this.l_Nombre.Text = "";
            this.l_Apellido.Text = "";
            this.l_eMail.Text = "";
            this.t_clientes.DataSource = null;
            this.t_clientes.Refresh();
        }
    }
}
