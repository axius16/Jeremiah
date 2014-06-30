using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.DAO;
using FrbaCommerce.Modelo;
using FrbaCommerce.Conexion;

namespace FrbaCommerce.Login
{
    public partial class CambiarPass : Form
    {
        public CambiarPass()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                String v_usuario = l_passAnterior.Text.Trim();
                String v_password = l_passNueva.Text;

                if (string.IsNullOrEmpty(v_usuario))
                    throw new Exception("Ingrese el nombre del Usuario.");

                if (string.IsNullOrEmpty(v_password))
                    throw new Exception("Ingrese la Contraseña.");

                Usuario usuario = DaoLogin.validarUsuario(v_usuario, v_password);

                if (!usuario.habilitado)
                    throw new Exception("El usuario " + v_usuario + " se encuentra Inhabilitado.");

                if (usuario.getRolesActivos().Count > 0)
                {
                    DBConexion.usuario = usuario;

                    if (DBConexion.usuario.primerIngreso)
                    {
                        MessageBox.Show("Debe cambiar su contraseña para poder continuar.", "Aviso");

                        CambiarPass cambioPass = new CambiarPass();
                        cambioPass.ShowDialog();
                        MessageBox.Show("Por favor ingrese nuevamente su contraseña.", "Aviso");
                        return;
                    }


                    if (usuario.getRolesActivos().Count > 1)
                    {
                        //Posee mas de un rol activo asignado, debe seleccionar uno solo
                        SeleccionRol seleccionRol = new SeleccionRol();
                        //var chooseRol = new FrmChooseRol();
                        //chooseRol.ShowDialog();
                    }
                    else
                    {
                        //Posee un unico rol asignado activo. Lo seteo en sesion.
                        //SessionManager.CurrentRol = user.RolesActivos.First();

                        //Muestro el formulario de home
                        //var home = new FrmHome();
                        //home.ShowDialog();
                    }

                    //Close();
                }
                else
                    throw new Exception("El usuario no cuenta con roles que se encuentren activos.");
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "ERROR"); 
           }
        }

          
        private void bCancelar_Click(object sender, EventArgs e)
        {
            //validar si hay una pass anterior, si existe y esta seteada, se debe ingresar una nueva si o si
        } 
    }
}
