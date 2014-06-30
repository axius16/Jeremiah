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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
        
            String v_usuario = l_usuario.Text.Trim();
            String v_password = l_password.Text ;
            
            if (string.IsNullOrEmpty(v_usuario))
                throw new Exception("Ingrese el nombre del Usuario.");

            if (string.IsNullOrEmpty(v_password))
                throw new Exception("Ingrese la Contraseña.");

            
            Usuario usuario = DaoLogin.validarUsuario(v_usuario, v_password);

            if (!usuario.habilitado)
                throw new Exception("El usuario "+v_usuario+" se encuentra Inhabilitado.");

            if (usuario.getRolesActivos().Count>0)
            {
                DBConexion.usuario = usuario;

                if (DBConexion.usuario.primerIngreso)
                {
                    MessageBox.Show("Debe cambiar su contraseña para poder continuar.", "Aviso");

                    CambiarPass cambioPass = new CambiarPass();
                    cambioPass.ShowDialog();

                    MessageBox.Show("Por favor Ingrese nuevamente su constraseña.", "Aviso");

                    return;
                }
                
                List<Rol> rolesActivos = usuario.getRolesActivos();

                if (rolesActivos.Count > 1)
                {
                    SeleccionRol seleccionRol = new SeleccionRol();
                    seleccionRol.ShowDialog();
                    if (DBConexion.rolSeleccionado == null)
                    {
                        return;
                    }
                    else { 
                        //cierro esta ventana
                        //abro la ventana de seleccion de menus
                    }
                }
                else
                {
                    DBConexion.rolSeleccionado = rolesActivos.First();
                    //SessionManager.CurrentRol = user.RolesActivos.First();
                    //cierro esta ventana
                    //abro la ventana de seleccion de menus
                }                
            }
            else
                throw new Exception("El usuario no cuenta con roles que se encuentren activos.");
        }
                   

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        } 

        

    }
}
