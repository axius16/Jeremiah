using System;
using System.Data.SqlClient;
using FrbaCommerce.Conexion;
using System.Data;
using FrbaCommerce.Modelo;
using System.Collections.Generic;
namespace FrbaCommerce.DAO
{
    class DaoLogin
    {

        public static Usuario validarUsuario(String p_username, String p_pass)
        {
            String query =
                "select * from DD.Usuario" +
                "where id_usuario = '"+p_username+"'" +
                "and password = '"+p_pass+"'";

            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();
            
            Usuario usuario = new Usuario();
            
            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    usuario.nombreUsuario = rs.GetString(rs.GetOrdinal("id_usuario"));
                    usuario.password = p_pass;                    
                }
            }

            conn.Close();
        
         

    

            return null;
        }

    }
    }

