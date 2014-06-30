using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Funcion
    {
        Int16 id { get; set; }
        String descripcion { get; set; }

        public Funcion(String descripcion, Int16 id)
        {
            this.id = id;
            this.descripcion = descripcion;
        }
        public static List<Funcion> listaDeFuncionalidades(){
            //TODO LISTA HARCODEADA
            List<Funcion> listaFunc = new List<Funcion>();

            Funcion altaCliente = new Funcion("Dar de alta un cliente", 1);
            listaFunc.Add(altaCliente);
            Funcion altaEmpresa = new Funcion("Dar de alta una empresa", 2);
            listaFunc.Add(altaEmpresa);
            Funcion bajaCliente = new Funcion("Dar de baja un cliente", 3);
            listaFunc.Add(bajaCliente);
            Funcion bajaEmpresa = new Funcion("Dar de baja una empresa", 4);
            listaFunc.Add(bajaEmpresa);
            Funcion listSelecionad = new Funcion("Listado de usuario seleccionado", 5);
            listaFunc.Add(listSelecionad);
            Funcion modEmpresa = new Funcion("Modificar datos de empresa", 6);
            listaFunc.Add(modEmpresa);
            Funcion modifCliente = new Funcion("Modificar datos de cliente", 7);
            listaFunc.Add(modifCliente);
            Funcion bajaRol = new Funcion("Dar de baja un rol", 2);
            listaFunc.Add(bajaRol);
            Funcion listRol = new Funcion("Listado de un rol seleccionado", 8);
            listaFunc.Add(listRol);
            Funcion modifRol = new Funcion("Modificar datos de rol", 9);
            listaFunc.Add(modifRol);
            Funcion subasta = new Funcion("Publicar subasta", 10);
            listaFunc.Add(subasta);
            Funcion compraInmediata = new Funcion("Publicar compra inmediata", 11);
            listaFunc.Add(compraInmediata);
            Funcion facturarPubli = new Funcion("Facturar publicaciones", 12);
            listaFunc.Add(facturarPubli);
            Funcion mostrarHistorial = new Funcion("Mostrar historial", 13);
            listaFunc.Add(mostrarHistorial);
            
            return listaFunc;
        }
    }
}

