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
/**/
namespace FrbaCommerce.FrbaCommerce.Abm_Cliente
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
            ventana.Show();
            System.Console.WriteLine("Clic en Insert");
        }

        private void bModificacion_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Clic en Modificar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bBaja_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Clic en Eliminar");
        }

        

        
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        
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

        }
    }
}
