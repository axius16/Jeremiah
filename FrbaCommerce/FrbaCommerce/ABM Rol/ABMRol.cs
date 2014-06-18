using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Rol
{
    public partial class Form1 : Form
    {

            
        

        public Form1()
        {
            InitializeComponent();
            
                      
        }

        public static void comboBoxFuncionalidades(ComboBox cmbFuncionalidad)
        {

            List<Modelo.Funcion> lista = Modelo.Funcion.listaDeFuncionalidades();
            cmbFuncionalidad.DataSource = lista;
            cmbFuncionalidad.DisplayMember = "funcionalidad";
            cmbFuncionalidad.ValueMember = "id";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {

        }

        private void bModificacion_Click(object sender, EventArgs e)
        {

        }

        private void bAlta_Click(object sender, EventArgs e)
        {

        }

        private void bBaja_Click(object sender, EventArgs e)
        {

        }
      

       
      
      
    }
}
