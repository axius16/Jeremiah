using System;
using System.Data.SqlClient;
using FrbaCommerce.Conexion;
using System.Data;
using FrbaCommerce.Modelo;
using System.Collections.Generic;
namespace FrbaCommerce.DAO
{
    class DaoTelefono
    {
        public void asignarTelefono(Cliente cliente, Int16 numeroTelefono) {
            
            Telefono telefono = new Telefono(cliente.idCliente, numeroTelefono.ToString());

            String sql =
            "insert into DD.Telefono (id_cliente, numero_telefono)" +
            "values (" + cliente.idCliente + ", " + numeroTelefono +")";

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            
            cliente.telefonos.Add(telefono);
            
        }

        public void desasignarTelefono(Cliente cliente, Telefono telefono)
        {
            String sql =
            "delete from DD.Telefono " +
            "where id_cliente = " + cliente.idCliente +
            "and telefono = " + telefono.numeroTelefono;

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

            cliente.telefonos.Remove(telefono);
            
            ;
        }


        public bool validarTelefono(Int16 numeroTelefono) {

            bool telefonoDisponible = true;
            String query =
            "select 1 from DD.Telefono where telefono = " +
            numeroTelefono;

            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    telefonoDisponible = false;
                }
            }
            conn.Close();

            return telefonoDisponible;
        }



        public List<Telefono> getTelefonos(Cliente unCliente)
        {
            List<Telefono> telefonosCliente = new List<Telefono>();

            String query = "select * from DD.Telefono" +
                "where id_cliente = " + unCliente.idCliente;
                
            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {

                if (!rs.IsDBNull(0))
                {
                    Telefono unTelefono = new Telefono();
                    unTelefono.idCliente = unCliente.idCliente;
                    unTelefono.numeroTelefono = (rs.GetInt32(rs.GetOrdinal("numero_telefono"))).ToString();
                    telefonosCliente.Add(unTelefono);
                }

            }
            conn.Close();
            return telefonosCliente;
        }
    }
}
