using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelo;
using FrbaCommerce.Conexion;
using System.Data.SqlClient;
using System.Data;


namespace FrbaCommerce.DAO
{
    class DaoVisibilidad
    {
        public DaoVisibilidad() { }

        static public List<Visibilidad> getVisibilidades(String p_codigo, String p_descripcion)
        {
            List<Visibilidad> visibilidades = new List<Visibilidad>();

            String query = "";
            // codigo descripcion
            if ((p_codigo == null || p_codigo == "") && (p_descripcion == null || p_descripcion == ""))
            {
                query = "select * from DD.visibilidad";
            }
            else
            {
                //logica para construir la query
                query = "SELECT * FROM DD.visibilidad " +
                "where codigo like '%" + p_codigo + "%' " +
                "and descripcion like '%" + p_descripcion + "%' ";
            }            

            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    Visibilidad visibilidad = new Visibilidad();
                    visibilidad.idVisibilidad= rs.GetDecimal(rs.GetOrdinal("id_visibilidad"));
                    visibilidad.codigo = rs.GetDecimal(rs.GetOrdinal("codigo"));
                    visibilidad.descripcion = rs.GetString(rs.GetOrdinal("descripcion"));
                    visibilidad.porcentaje = rs.GetDecimal(rs.GetOrdinal("precio"));
                    visibilidad.precio = rs.GetDecimal(rs.GetOrdinal("porcentaje"));
                    visibilidad.cantidadDias = rs.GetDecimal(rs.GetOrdinal("cant_dias"));
                    visibilidades.Add(visibilidad);
                }

            }
            conn.Close();
            return visibilidades;
        }

        static public List<Visibilidad> getAllVisibilidades() {
            return getVisibilidades(null, null);
        }

        static public void persistir(Visibilidad visibilidad)
        {
            if (visibilidad.idVisibilidad == 0)
            {
                insertVisibilidad(visibilidad);
            }
            else {
                updateVisibilidad(visibilidad);
            }
                        
        }

        private static void updateVisibilidad(Visibilidad visibilidad)
        {
            String sql =
            "update DD.visibilidad " +
            "set codigo = '" + visibilidad.codigo + "', " +
            "descripcion = '" + visibilidad.descripcion + "', " +
            "precio = '" + visibilidad.precio + "', " +
            "porcentaje  = '" + visibilidad.porcentaje + "', " +
            "cant_dias = '" + visibilidad.cantidadDias + "' " +
            "where id_visibilidad = " + visibilidad.idVisibilidad;

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            ;
        }

        private static Decimal getProximoIdVisibilidad()
        {
            String query = "select isnull((select MAX(id_visibilidad)+1), 1) as id_visibilidad from DD.visibilidad";
            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();
            Decimal idVisibilidad = 0;
            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    idVisibilidad = rs.GetInt32(rs.GetOrdinal("id_visibilidad"));
                }

            }
            conn.Close();
            return idVisibilidad;
        }

        private static void insertVisibilidad(Visibilidad visibilidad)
        {
            Decimal nuevoIdVisibilidad = getProximoIdVisibilidad();
            String sql =
            "insert into DD.visibilidad " +
            "(id_visibilidad, codigo, descripcion, " +
            "precio, porcentaje, cant_dias) " +
            "values " +
            nuevoIdVisibilidad + ", " +
            visibilidad.codigo + ", '" +
            visibilidad.descripcion + "', '" +
            visibilidad.precio + "', '" +
            visibilidad.porcentaje + "', '" +
            visibilidad.cantidadDias+ "')";

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        internal static void eliminar(Visibilidad visibilidad)
        {
            String sql =
            "delete from DD.visibilidad " +
            "where id_visibilidad = " + visibilidad.idVisibilidad;

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
