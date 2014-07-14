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
    class DaoRubro
    {
        private static List<Rubro> rubros;
        public DaoRubro() { }

        public static Rubro getRubro(Decimal p_idRubro)
        {
            if (rubros == null)
            {
                DaoRubro.getRubros();
            }
            Rubro rubro = rubros.Find(x => x.idRubro == p_idRubro);
            return rubro;
        }

        static public List<Rubro> getRubrosPorPublicacion(Decimal p_idPublicacion)
        {
            if (rubros == null)
            {
                DaoRubro.getRubros();
            }

            List<Rubro> rubrosPorPublicacion = new List<Rubro>();

            String query = "select * from dd.Publicacion_Rubro"+
                           "where id_publicacion = " + p_idPublicacion;

            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                  Decimal idRubroPublicacion = rs.GetDecimal(rs.GetOrdinal("id_rubro"));
                  rubrosPorPublicacion.Add(rubros.Find(x => x.idRubro == idRubroPublicacion));                   
                }
            }
            conn.Close();
            return rubrosPorPublicacion;
        }

        static public List<Rubro> getRubros()
        {
            if (rubros != null)
            {
                return rubros;
            }

            rubros = new List<Rubro>();

            String query = "select * from dd.rubro";

            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    Rubro rubro = new Rubro();
                    rubro.idRubro = rs.GetDecimal(rs.GetOrdinal("id_rubro"));
                    rubro.codigo = rs.GetDecimal(rs.GetOrdinal("codigo"));
                    rubro.descripcion = rs.GetString(rs.GetOrdinal("decripcion"));
                    rubros.Add(rubro);
                }
            }
            conn.Close();
            return rubros;
        }
    }

}
