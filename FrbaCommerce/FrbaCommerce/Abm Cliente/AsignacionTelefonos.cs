using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/**/
namespace FrbaCommerce.Asignacion_Telefonos
{
    public partial class AsignacionTelefonos : Form
    {
        public AsignacionTelefonos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bAsignar_Click(object sender, EventArgs e)
        {
            //validar si el telefono existe
            //si existe, mostrar el error en la label
            //si no exise, asignar a mi cliente
        }

        private void bDesasignar_Click(object sender, EventArgs e)
        {
            //desasignar de mi cliente
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
