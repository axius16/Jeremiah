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
    class DaoRol
    {
        public DaoRol() { }

        static public List<Rol> getRoles(String p_rol)
        {
            List<Rol> roles = new List<Rol>();

            String query = "";
            if (p_rol == null || p_rol == "")
            {
                query = "select * from DD.rol";
            }
            else
            {
                 query = "SELECT * FROM DD.rol " +
                "where nombre like '%" + p_rol + "%' ";
            }

            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    Rol rol = new Rol();
                    rol.idRol = rs.GetDecimal(rs.GetOrdinal("id_rol"));
                    rol.idEstado = rs.GetDecimal(rs.GetOrdinal("id_estado"));
                    rol.descipcion = rs.GetString(rs.GetOrdinal("nombre"));
                    rol.habilitado = rs.GetBoolean(rs.GetOrdinal("habilitado"));
                    roles.Add(rol);
                }

            }
            conn.Close();
            return roles;
        }

        static public List<Rol> getAllRoles()
        {
            return getRoles(null);
        }

        static public void persistir(Rol rol)
        {
            if (rol.idRol == 0)
            {
                insertRol(rol);
            }
            else
            {
                updateRol(rol);
            }

        }

        private static void updateRol(Rol rol)
        {
            String sql =
            "update dd.Rol" +
            "set id_estado = '%" + rol.idEstado.ToString() + "%'," +
            "nombre = '%" + rol.descipcion + "%'," +
            "habilitado = '%" + rol.habilitado.ToString() + "%'" +
            "where id_rol = " + rol.idRol.ToString();

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            actualizarFuncionalidades(rol);
        }

        private static void actualizarFuncionalidades(Rol rol)
        {
            List<Funcionalidad> funcionalidadesAnteriores = DaoFuncionalidad.getFuncionalidadesPorRol(rol);
            List<Funcionalidad> funcionalidadesNuevas = rol.funciones;
            List<Funcionalidad> funcionalidadesQuitadas = funcionalidadesAnteriores;
            foreach (var unaFunc in rol.funciones){   
                //funciones de la base menos las del objeto = quitadas
                funcionalidadesQuitadas.Remove(unaFunc);
            }
            foreach (var unaFunc in funcionalidadesAnteriores)
            {
                //funciones del objeto menos las de la base = quitadas
                funcionalidadesNuevas.Remove(unaFunc);
            }
            quitarFuncionalidades(rol.idRol, funcionalidadesAnteriores);
            insertarFuncionalidades(rol.idRol, funcionalidadesNuevas);

        }

        private static void quitarFuncionalidades(Decimal idRol, List<Funcionalidad> funcionalidadesDesasignadas)
        {
            SqlConnection conn = DBConexion.getConn();
            foreach (var unaFunc in funcionalidadesDesasignadas)
            {
                String sql =
                "delete from dd.funcion_rol" +
                "where id_rol = " + idRol + " "+ 
                "and id_funcion = " +unaFunc.id;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }


        private static void insertarFuncionalidades(Decimal idRol, List<Funcionalidad> funcionalidadesNuevas)
        {
            SqlConnection conn = DBConexion.getConn();
            foreach (var unaFunc in funcionalidadesNuevas)
            {
                String sql =
                "insert into dd.funcion_rol" +
                "(id_rol, id_funcion)" +
                "values" +
                "('" + idRol + "', '"
                + unaFunc.id + "');";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        private static Decimal getProximoIdRol()
        {
            String query = "select isnull((select MAX(id_rol)+1), 1) as id_rol from DD.rol";
            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();
            Decimal idRol = 0;
            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    idRol = rs.GetDecimal(rs.GetOrdinal("id_rol"));
                }

            }
            conn.Close();
            return idRol;
        }

        private static void insertRol(Rol rol)
        {
            Decimal nuevoIdRol = getProximoIdRol();
            String sql =
            "insert into dd.Rol" +
            "(id_rol, id_estado, nombre, habilitado)" +
            "values" +
            "('" + nuevoIdRol + "', '"
            + rol.idEstado + "', '"
            + rol.descipcion + "', '"
            + rol.habilitado + "');";

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

            insertarFuncionalidades(nuevoIdRol, rol.funciones);
        }


        internal static void habilitar(Rol rol, Boolean bol)
        {
            String sql =
            "update DD.rol " +
            "set habilitado = " + bol.ToString() +
            "where id_rol = " + rol.idRol;

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
