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
    class DaoTipoPublicacion
    {
        private static List<TipoPublicacion> tiposPublicacion;
        public DaoTipoPublicacion() { }

        public static TipoPublicacion getTipoPublicacion(Decimal p_idTipo)
        {
            if (tiposPublicacion == null)
            {
                DaoTipoPublicacion.getTiposPublicacion();
            }
            TipoPublicacion tipo = tiposPublicacion.Find(x => x.idTipoPublicacion == p_idTipo);
            return tipo;
        }

        static public List<TipoPublicacion> getTiposPublicacion()
        {
            if (tiposPublicacion == null)
            {
                return tiposPublicacion;
            }

            tiposPublicacion = new List<TipoPublicacion>();

            String query = "select * from dd.tipo_publicacion";
            
            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    TipoPublicacion tipoPublicacion = new TipoPublicacion();
                    tipoPublicacion.idTipoPublicacion = rs.GetDecimal(rs.GetOrdinal("id_tipo"));
                    tipoPublicacion.descripcion = rs.GetString(rs.GetOrdinal("decripcion"));
                    tiposPublicacion.Add(tipoPublicacion);
                }
            }
            conn.Close();
            return tiposPublicacion;
        }
    }

}
