using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.FrbaCommerce.Generar_Publicacion
{
    public partial class GenerarPublicacion : Form
    {
        List<Rubro> rubrosDisponibles;
        List<Rubro> rubrosAsignados;
        Publicacion publicacion;

        public GenerarPublicacion()
        {
            InitializeComponent();
            //rubrosDisponibles = DaoRubro.getAllRubros();
            rubrosDisponibles = new List<Rubro>();
            //refresco las grillas
            //cargo combo tipoPublicacion
            //cargo combo visibilidad
            //cargo combo estado
        }

        public void setearPublicacion(Object unaPublicacion){
            this.publicacion = (Publicacion)unaPublicacion;
            this.rubrosAsignados = publicacion.rubros;
            List<Rubro> aux = this.rubrosDisponibles;
            foreach (Rubro unRubro in this.rubrosAsignados)
            {
                this.rubrosDisponibles.Remove(unRubro);
            }
            this.t_descripcion.Text = this.publicacion.descripcion;
                        
            String precio = "";
            try { precio = this.publicacion.precio.ToString(); }
            catch { precio = ""; }
            this.t_valor.Text = precio;

            String stock = "";
            try { stock = this.publicacion.stock.ToString(); }
            catch { stock = ""; }
            this.t_stock.Text = stock;

            //seteo combo tipoPublicacion
            //seteo combo visibilidad
            //seteo combo estado
            //refresco las grillas
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            //valido si es una publicacion nueva o no
            //si es nueva
                //creo el objeto publicacion
            //asigno todas las variables 
            //invoco la dao para grabar
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void b_movDcha_Click(object sender, EventArgs e)
        {
            //tomar el objeto de la grilla de asignados
            //quitarlo de la coleccion de asignados
            //agregarlo a la coleccion de libres
            //refescar las grillas
        }

        private void b_movIzq_Click(object sender, EventArgs e)
        {
            //tomar el objeto de la grilla de libres
            //quitarlo de la coleccion de libres
            //agregarlo a la coleccion de asignados
            //refescar las grillas
        }
    }
}
