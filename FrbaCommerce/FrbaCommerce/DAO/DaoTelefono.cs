using System;
using System.Data.SqlClient;
using FrbaCommerce.Conexion;
using System.Data;
using FrbaCommerce.Modelo;
namespace FrbaCommerce.DAO
{
    class DaoTelefono
    {
        public void asignarTelefono(Cliente cliente, Int16 numeroTelefono) {
            
            Telefono telefono = new Telefono(cliente.idCliente, numeroTelefono.ToString());

            String sql =
            "update DD.Usuario_Cliente " +
            "set telefono = " + numeroTelefono +
            "where id_cliente = " + cliente.idCliente;

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
            "update DD.Usuario_Cliente " +
            "set telefono = null"+
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
            "select 1 from cliente where telefono = " +
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


    }
}
