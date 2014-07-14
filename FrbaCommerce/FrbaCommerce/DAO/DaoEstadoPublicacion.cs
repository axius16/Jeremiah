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
    class DaoEstadoPublicacion
    {
        private static List<EstadoPublicacion> estados;
        public DaoEstadoPublicacion() { }

        public static EstadoPublicacion getEstadoPublicacion(Decimal p_idEstado)
        {
            if (estados == null)
            {
                DaoEstadoPublicacion.getEstados();
            }
            EstadoPublicacion estado = estados.Find(x => x.idEstado == p_idEstado);
            return estado;
        }

        static public List<EstadoPublicacion> getEstados()
        {
            if (estados != null)
            {
                return estados;
            }

            estados = new List<EstadoPublicacion>();

            String query = "select * from dd.estado";
            
            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    EstadoPublicacion estado = new EstadoPublicacion();
                    estado.idEstado = rs.GetDecimal(rs.GetOrdinal("id_estado"));
                    estado.descripcion = rs.GetString(rs.GetOrdinal("decripcion"));
                    estados.Add(estado);
                }
            }
            conn.Close();
            return estados;
        }
    }

}
