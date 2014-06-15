using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/**/
namespace FrbaCommerce.FrbaCommerce.Asignacion_telefonos
{
    public partial class Form1 : Form
    {

            
        

        public Form1()
        {
            InitializeComponent();
                      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nueva ventana de insert
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

        private void bBuscar_Click(object sender, EventArgs e)
        {
            String textoBusqueda = l_buscar.Text;
            System.Console.WriteLine("Clic en Buscar");
            System.Console.WriteLine("Buscar: {0}", textoBusqueda);
            this.cargarDatosEntabla();
            
        }

        static DataTable getTable()
        {
            //
            // Here we create a DataTable with four columns.
            //
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            //
            // Here we add five DataRows.
            //
            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            return table;
        }

        public void cargarDatosEntabla() {
                        
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
