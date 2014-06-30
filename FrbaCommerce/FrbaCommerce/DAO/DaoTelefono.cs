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
        public void asignarTelefono(Cliente cliente, Decimal numeroTelefono)
        {
            
            Telefono telefono = new Telefono(cliente, numeroTelefono);

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

        public void asignarTelefono(Empresa empresa, Decimal numeroTelefono)
        {

            Telefono telefono = new Telefono(empresa, numeroTelefono);

            String sql =
            "insert into DD.Telefono (id_empresa, numero_telefono)" +
            "values (" + empresa.idEmpresa + ", " + numeroTelefono + ")";

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

            empresa.telefonos.Add(telefono);

        }

        public void desasignarTelefono(Cliente cliente, Telefono telefono)
        {
            String sql =
            "delete from DD.Telefono " +
            "where id_cliente = " + cliente.idCliente +
            "and numero_telefono = " + telefono.numeroTelefono;

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

        public void desasignarTelefono(Empresa empresa, Telefono telefono)
        {
            String sql =
            "delete from DD.Telefono " +
            "where id_empresa = " + empresa.idEmpresa +
            "and numero_telefono = " + telefono.numeroTelefono;

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

            empresa.telefonos.Remove(telefono);

            ;
        }
        
        public List<Telefono> getTelefonos(Cliente unCliente)
        {
            List<Telefono> telefonosCliente = new List<Telefono>();

            String query = "select * from DD.Telefono " +
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
                    unTelefono.numeroTelefono = rs.GetDecimal(rs.GetOrdinal("numero_telefono"));
                    telefonosCliente.Add(unTelefono);
                }

            }
            conn.Close();
            return telefonosCliente;
        }

        public List<Telefono> getTelefonos(Empresa unaEmpresa)
        {
            List<Telefono> telefonosEmpresa = new List<Telefono>();

            String query = "select * from DD.Telefono " +
                "where id_empresa = " + unaEmpresa.idEmpresa;

            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {

                if (!rs.IsDBNull(0))
                {
                    Telefono unTelefono = new Telefono();
                    unTelefono.idEmpresa = unaEmpresa.idEmpresa;
                    unTelefono.numeroTelefono = rs.GetDecimal(rs.GetOrdinal("numero_telefono"));
                    telefonosEmpresa.Add(unTelefono);
                }

            }
            conn.Close();
            return telefonosEmpresa;
        }

        //
        // Devuelve true si el telefono se encuentra disponible
        // Devuelve false si el telefono esta en uno por un cliente
        //
        public bool validarTelefono(Decimal numeroTelefono)
        {

            bool telefonoDisponible = true;
            String query =
            "select 1 from DD.Telefono where numero_telefono = " +
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
