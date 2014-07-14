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
    class DaoPublicacion
    {
        public DaoPublicacion() { }

        static public List<Publicacion> getPublicaciones(String p_codigo, String p_descripcion)
        {
            List<Publicacion> publicaciones = new List<Publicacion>();

            String query = "";
            // codigo descripcion
            if ((p_codigo == null || p_codigo == "") && (p_descripcion == null || p_descripcion == ""))
            {
                query = "select * from DD.publicacion";
            }
            else
            {
                //logica para construir la query
                query = "select * from dd.publicacion"+
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
                    //id_publicacion, id_usuario, id_estado, id_visibilidad, 
                    //tipo_publicacion, precio_publicacion, codigo, descripcion, 
                    //fecha, fecha_venc, f_preguntas, f_bonificada, f_rendida
                    Publicacion publicacion = new Publicacion();
                    publicacion.idPublicacion = rs.GetDecimal(rs.GetOrdinal("id_publicacion"));
                    publicacion.vendedor = DaoUsuario.getUsuario( rs.GetDecimal(rs.GetOrdinal("id_usuario")));
                    publicacion.estado = DaoEstadoPublicacion.getEstadoPublicacion(rs.GetDecimal(rs.GetOrdinal("id_estado")));
                    publicacion.visibilidad= DaoVisibilidad.getVisibilidad(rs.GetDecimal(rs.GetOrdinal("id_visibilidad")));
                    publicacion.tipoPublicacion = DaoTipoPublicacion.getTipoPublicacion(rs.GetDecimal(rs.GetOrdinal("tipo_publicacion")));
                    publicacion.precio = rs.GetDecimal(rs.GetOrdinal("precio_publicacion"));
                    publicacion.codigoPublicacion = rs.GetString(rs.GetOrdinal("codigo"));
                    publicacion.descripcion = rs.GetString(rs.GetOrdinal("descripcion"));
                    publicacion.fechaInicio = rs.GetDateTime(rs.GetOrdinal("fecha"));
                    publicacion.fechaVencimiento = rs.GetDateTime(rs.GetOrdinal("fecha_venc"));
                    publicacion.preguntasActivas = rs.GetBoolean(rs.GetOrdinal("f_preguntas"));
                    publicacion.flagBonificada = rs.GetBoolean(rs.GetOrdinal("f_bonificada"));
                    publicacion.flagRendida = rs.GetBoolean(rs.GetOrdinal("f_rendida"));
                    publicacion.rubros = DaoRubro.getRubrosPorPublicacion(publicacion.idPublicacion);
                    publicaciones.Add(publicacion);
                }

            }
            conn.Close();
            return publicaciones;
        }

        static public List<Publicacion> getAllPublicaciones() {
            return getPublicaciones(null, null);
        }

        static public void persistir(Publicacion publicacion)
        {
            if (publicacion.idPublicacion  == 0)
            {
                insertPublicacion(publicacion);
            }
            else {
                updatePublicacion(publicacion);
            }
                        
        }

        private static void updatePublicacion(Publicacion publicacion)
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

        private static Decimal getProximoIdPublicacion()
        {
            String query = "select isnull((select MAX(id_publicacion)+1), 1) as id_Publicacion from DD.Publicacion";
            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();
            Decimal idPublicacion = 0;
            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    idPublicacion = rs.GetDecimal(rs.GetOrdinal("id_Publicacion"));
                }

            }
            conn.Close();
            return idPublicacion;
        }

        private static void insertPublicacion(Publicacion publicacion)
        {
            Decimal nuevoIdPublicacion = getProximoIdPublicacion();
            String sql =
            "insert into DD.visibilidad " +
            "(id_visibilidad, codigo, descripcion, " +
            "precio, porcentaje, cant_dias) " +
            "values " +
            nuevoIdPublicacion + ", " +
            publicacion.codigo + ", '" +
            publicacion.descripcion + "', '" +
            publicacion.precio + "', '" +
            publicacion.porcentaje + "', '" +
            publicacion.cantidadDias + "')";

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
