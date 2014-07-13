using System;
using System.Data.SqlClient;
using FrbaCommerce.Conexion;
using System.Data;
using FrbaCommerce.Modelo;
using System.Collections.Generic;
namespace FrbaCommerce.DAO
{
    class DaoTipoDocumento
    {

        static List<TipoDocumento> tiposDocumento = null;

        public static TipoDocumento getTipoDocumento(Decimal id_TipoDocumento)
        {
            if (tiposDocumento == null)
            {
                DaoTipoDocumento.getAll();
            }
            TipoDocumento docFiltrado = tiposDocumento.Find(x => x.idTipoDocumento == id_TipoDocumento);
            return docFiltrado;
        }

        public static List<TipoDocumento> getAll()
        {
            String query = "select * from dd.tipo_documento";
            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();
            tiposDocumento = new List<TipoDocumento>();
            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    TipoDocumento tipoDoc = new TipoDocumento();
                    tipoDoc.idTipoDocumento = rs.GetInt32(rs.GetOrdinal("id_tipo_documento"));
                    tipoDoc.descTipoDocumento = rs.GetString(rs.GetOrdinal("desc_tipo_documento"));
                    tiposDocumento.Add(tipoDoc);
                }
            }
            conn.Close();
            return tiposDocumento;
        }
    }
}
