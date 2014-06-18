﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.FrbaCommerce.Modelo;
using FrbaCommerce.Conexion;
using System.Data.SqlClient;
using System.Data;


namespace FrbaCommerce.FrbaCommerce.DAO
{
    class DaoCliente
    {
        public DaoCliente() { 
        }

        public Cliente getInstance(UInt32 idCliente){
           return null;
        }

        static public List<Cliente> getClientes(String apellido, String nombre, String dni, String tipoDoc, String mail) {
            List<Cliente> clientes = new List<Cliente>();

            String query = "";
            // apellido nombre dni tipoDOc mail
            if ((apellido == null || apellido == "") && (nombre == null || nombre == "") &&
                (dni == null || dni == "") && (tipoDoc == null || tipoDoc == "")
                && (mail == null || mail == ""))
            {
                query = "select * from DD.Usuario_Cliente";
            }
            else
            {
                //logica para construir la query
                query = "SELECT * FROM DD.usuario_cliente " +
                "where apellido like '%" + apellido + "%' " +
                "and nombre like '%" + nombre + "%' " +
                "and telefono like '%" + mail + "%'" +
                " and nro_doc like '%" + dni + "%'" +
                " and tipo_doc like '%" + tipoDoc + "%'";
            }
            

            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {

                if (!rs.IsDBNull(0))
                {
                    Cliente cliente = new Cliente();
                    cliente.idCliente = rs.GetInt32(rs.GetOrdinal("id_usuario"));
                    cliente.tipoDocumento = (rs.GetInt16(rs.GetOrdinal("tipo_doc"))).ToString();
                    cliente.numeroDocumento = rs.GetDecimal(rs.GetOrdinal("nro_doc"));
                    cliente.apellido = rs.GetString(rs.GetOrdinal("apellido"));
                    cliente.nombre = rs.GetString(rs.GetOrdinal("nombre"));
                    cliente.fechaNacimiento = rs.GetDateTime(rs.GetOrdinal("fecha_nac"));
                    cliente.cuil = rs.GetString(rs.GetOrdinal("cuil"));
                    cliente.mail = rs.GetString(rs.GetOrdinal("telefono"));

                    clientes.Add(cliente);
                }

            }
            conn.Close();
            return clientes;
        }

        static public List<Cliente> getAllClientes() {
            return getClientes(null, null, null, null, null);
        }

        static public void persistir(Cliente cliente)
        {
            String fecha = cliente.fechaNacimiento.ToString("d");

            String sql =
            "insert into DD.Usuario_Cliente " +
            "(id_usuario, id_domicilio, tipo_doc, "+
            "nro_doc, apellido, nombre, fecha_nac, cuil, telefono) " +
            "values " +
            "(isnull((select MAX(id_usuario)+1 from DD.Usuario_Cliente), 1), 1, 1, " +
            cliente.numeroDocumento+", '" + cliente.apellido + "', '"+
            cliente.nombre + "', '" + fecha + "', '" +
            cliente.cuil+"', '"+cliente.mail+"')";
            
            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            ;            
        } 

    }
}
