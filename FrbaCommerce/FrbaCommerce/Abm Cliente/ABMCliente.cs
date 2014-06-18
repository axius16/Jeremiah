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
/**/
namespace FrbaCommerce.Abm_Cliente
{
    public partial class ABMCliente : Form
    {           
        

        public ABMCliente()
        {
            InitializeComponent();
                      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            DAO.DaoCliente.eliminar(cliente);
            this.Buscar_Click(sender, e);
        
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String numeroDocumento = Convert.ToString(l_NumeroDocumento.Text);
            String  tipoDocumento = Convert.ToString (l_TipoDocumento.Text);
            String nombre = Convert.ToString(l_Nombre.Text);
            String apellido = Convert.ToString(l_Apellido.Text);
            String mail = Convert.ToString(l_eMail.Text);

            SQLUtils.SQLUtils.cargarTabla(this.t_clientes, DAO.DaoCliente.getClientes(apellido, nombre, numeroDocumento, tipoDocumento, mail));
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.l_NumeroDocumento.Text = "";
            this.l_TipoDocumento.Text = "";
            this.l_Nombre.Text = "";
            this.l_Apellido.Text = "";
            this.l_eMail.Text = "";
            this.t_clientes.DataSource = null;
            this.t_clientes.Refresh();
        }
    }
}
