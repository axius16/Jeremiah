﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelo;
using FrbaCommerce.Conexion;
using System.Data.SqlClient;
using System.Data;


namespace FrbaCommerce.DAO
{
    class DaoUsuario
    {
        public DaoUsuario()
        {
        }

        static public Usuario getUsuario(Decimal idUsuario)
        {

            String query = "";
            // apellido nombre dni tipoDOc mail

            //logica para construir la query
            query = "SELECT * FROM DD.usuario_cliente " +
            "where apellido like '%" + apellido + "%' " +
            "and nombre like '%" + nombre + "%' " +
            "and mail like '%" + mail + "%'" +
            " and nro_doc like '%" + dni + "%'";



            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    Cliente cliente = new Cliente();
                    Direccion dir = new Direccion();
                    cliente.idCliente = rs.GetInt32(rs.GetOrdinal("id_usuario"));
                    cliente.tipoDocumento = new TipoDocumento(rs.GetInt16(rs.GetOrdinal("tipo_doc")));
                    cliente.numeroDocumento = rs.GetDecimal(rs.GetOrdinal("nro_doc"));
                    cliente.apellido = rs.GetString(rs.GetOrdinal("apellido"));
                    cliente.nombre = rs.GetString(rs.GetOrdinal("nombre"));
                    cliente.fechaNacimiento = rs.GetDateTime(rs.GetOrdinal("fecha_nac"));
                    cliente.cuil = rs.GetString(rs.GetOrdinal("cuil"));
                    cliente.mail = rs.GetString(rs.GetOrdinal("mail"));
                    cliente.telefonos = new DaoTelefono().getTelefonos(cliente);
                    dir.calle = rs.GetString(rs.GetOrdinal("calle"));
                    dir.numero = rs.GetDecimal(rs.GetOrdinal("nro_calle"));
                    dir.piso = rs.GetString(rs.GetOrdinal("piso"));
                    dir.departamento = rs.GetString(rs.GetOrdinal("depto"));
                    dir.codigoPostal = rs.GetString(rs.GetOrdinal("codigo_postal"));
                    dir.ciudad = rs.GetString(rs.GetOrdinal("ciudad"));
                    cliente.direccion = dir;
                    clientes.Add(cliente);
                }

            }
            conn.Close();
            return clientes;
        }

        static public List<Cliente> getAllClientes()
        {
            return getClientes(null, null, null, null, null);
        }

        static public void persistir(Cliente cliente)
        {
            if (cliente.idCliente == 0)
            {
                insertCliente(cliente);
            }
            else
            {
                updateCliente(cliente);
            }

        }

        private static void updateCliente(Cliente cliente)
        {
            String fecha = cliente.fechaNacimiento.ToString("d");

            String sql =
            "update DD.Usuario_Cliente " +
            "set id_domicilio = '" + cliente.numeroDocumento + "', " +
            "tipo_doc = '" + cliente.tipoDocumento.idTipoDocumento + "', " +
            "nro_doc = '" + cliente.numeroDocumento + "', " +
            "apellido = '" + cliente.apellido + "', " +
            "nombre = '" + cliente.nombre + "', " +
            "fecha_nac = '" + fecha + "', " +
            "cuil = '" + cliente.cuil + "', " +
            "mail = '" + cliente.mail + "', " +
            "calle = '" + cliente.direccion.calle + "', " +
            "nro_calle = '" + cliente.direccion.numero + "', " +
            "piso = '" + cliente.direccion.piso + "', " +
            "depto = '" + cliente.direccion.departamento + "', " +
            "codigo_postal = '" + cliente.direccion.codigoPostal + "', " +
            "ciudad = '" + cliente.direccion.ciudad + "' " +
            "where id_usuario = " + cliente.idCliente;

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            ;
        }

        private static Int32 getProximoIdCliente()
        {
            String query = "select isnull((select MAX(id_usuario)+1), 1) as id_cliente from DD.Usuario_Cliente";
            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();
            Int32 idCliente = 0;
            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    idCliente = rs.GetInt32(rs.GetOrdinal("id_cliente"));
                }

            }
            conn.Close();
            return idCliente;
        }

        private static void insertCliente(Cliente cliente)
        {
            String fecha = cliente.fechaNacimiento.ToString("d");
            Int32 nuevoIdCliente = getProximoIdCliente();

            String sql =
            "insert into DD.Usuario_Cliente " +
            "(id_usuario, tipo_doc, nro_doc, apellido, nombre, fecha_nac, " +
            "cuil, reputacion, mail, calle, " +
            "nro_calle, piso, depto, codigo_postal, localidad, ciudad)" +
            "values(" +
            nuevoIdCliente + ", '" +
            cliente.tipoDocumento.idTipoDocumento + "', '" +
            cliente.numeroDocumento + "', '" +
            cliente.apellido + "', '" +
            cliente.nombre + "', '" +
            fecha + "', '" +
            cliente.cuil + "', '" +
            cliente.mail + "', '" +
            cliente.direccion.calle + "', '" +
            cliente.direccion.numero + "', '" +
            cliente.direccion.piso + "', '" +
            cliente.direccion.departamento + "', '" +
            cliente.direccion.codigoPostal + "', '" +
            cliente.direccion.ciudad + "');";

            DaoTelefono daoTel = new DaoTelefono();
            //persistir telefonos

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        internal static void eliminar(Cliente cliente)
        {
            String sql =
            "delete from DD.Usuario_Cliente " +
            "where id_usuario = " + cliente.idCliente;

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
