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
    class DaoFuncionalidad
    {
        public DaoFuncionalidad() { }


        static public List<Funcionalidad> getFuncionalidadesPorRol(Rol p_rol)
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            String query = "";
            if (p_rol == null || p_rol.idRol == 0)
            {
                return funcionalidades;
                }
            else
            {
                //logica para construir la query
                query = "select f.id_funcion, f.descripcion" +
                        "from dd.rol r, dd.funcion_rol fr, dd.Funcion f" +
                        "where r.id_rol = fr.id_rol" +
                        "and fr.id_funcion = f.id_funcion" +
                        "and r.id_rol = "+p_rol.idRol;
            }

            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    Funcionalidad funcionalidad = new Funcionalidad();
                    funcionalidad.id = rs.GetDecimal(rs.GetOrdinal("id_funcional"));
                    funcionalidad.descripcion = rs.GetString(rs.GetOrdinal("descripcion"));
                    funcionalidades.Add(funcionalidad);
                }
            }
            conn.Close();
            return funcionalidades;
        }

        static public List<Funcionalidad> getFuncionalidades(String p_funcionalidad)
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            String query = "";
            if (p_funcionalidad == null || p_funcionalidad == "")             {
                query = "select * from DD.funcion";
            }
            else
            {
                //logica para construir la query
                query = "select id_funcion, descripcion"+
                        "from dd.funcion"+
                        "where descripcion like '%"+p_funcionalidad+"%'";
            }            

            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    Funcionalidad funcionalidad = new Funcionalidad();
                    funcionalidad.id = rs.GetDecimal(rs.GetOrdinal("id_funcional"));
                    funcionalidad.descripcion = rs.GetString(rs.GetOrdinal("descripcion"));
                    funcionalidades.Add(funcionalidad);
                }
            }
            conn.Close();
            return funcionalidades;
        }

        static public List<Funcionalidad> getAllFuncionalidades() {
            return getFuncionalidades(null);
        }

    }
}
