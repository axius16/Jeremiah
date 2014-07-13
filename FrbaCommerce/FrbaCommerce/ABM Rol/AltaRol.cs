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

namespace FrbaCommerce.ABM_Rol
{
    public partial class AltaRol : Form
    {
        List<Funcionalidad> funcionalidadesLibres = new List<Funcionalidad>();
        List<Funcionalidad> funcionalidadesAsignadas = new List<Funcionalidad>();
        Rol rol;

        public AltaRol()
        {
            InitializeComponent();
            funcionalidadesLibres = DaoFuncionalidad.getAllFuncionalidades();
            this.actualizarGrillas();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (rol == null) {
                this.rol = new Rol();
            }
            this.rol.descipcion = this.t_rol.Text;
            this.rol.habilitado = this.ch_habilitado.Checked;
            this.rol.funciones = this.funcionalidadesAsignadas;
            DaoRol.persistir(rol);
            this.Dispose();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setearRol(Object unRol)
        {
            if (unRol != null)
            {
                this.rol = (Rol) unRol;
                this.t_rol.Text = this.rol.descipcion;
                this.ch_habilitado.Checked = this.rol.habilitado;
                this.funcionalidadesAsignadas = DaoFuncionalidad.getFuncionalidadesPorRol(this.rol);
                foreach (var unaFunc in this.funcionalidadesAsignadas)
                {
                    this.funcionalidadesLibres.Remove(unaFunc);
                }
                this.actualizarGrillas();
            }                
        }

        private void actualizarGrillas() {
            SQLUtils.SQLUtils.cargarTabla(this.tb_admitidas, this.funcionalidadesAsignadas);
            SQLUtils.SQLUtils.cargarTabla(this.tb_admitidas, this.funcionalidadesLibres);
        }

        private void bMoverAIzquierda_Click(object sender, EventArgs e)
        {
            Funcionalidad funcion = new Funcionalidad();
            foreach (DataGridViewRow row in this.tb_disponibles.SelectedRows)
            {
                funcion = row.DataBoundItem as Funcionalidad;
            }
            this.funcionalidadesLibres.Remove(funcion);
            this.funcionalidadesLibres.Add(funcion);
            this.actualizarGrillas();
        }

        private void bMoverADerecha_Click(object sender, EventArgs e)
        {
            Funcionalidad funcion = new Funcionalidad();
            foreach (DataGridViewRow row in this.tb_admitidas.SelectedRows)
            {
                funcion = row.DataBoundItem as Funcionalidad;
            }            
            this.funcionalidadesAsignadas.Remove(funcion);
            this.funcionalidadesLibres.Add(funcion);
            this.actualizarGrillas();
        }

        private void bFiltrarFuncionalidad_Click(object sender, EventArgs e)
        {
            String filtro = this.t_funcionalidad.Text;
            SQLUtils.SQLUtils.cargarTabla(this.tb_admitidas, 
                this.funcionalidadesLibres.FindAll(x => x.descripcion == filtro));
        }
    }
}
