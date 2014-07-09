using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelo;
using FrbaCommerce.Conexion;
using System.Data.SqlClient;
using System.Data;
using FrbaCommerce.SQLUtils;


namespace FrbaCommerce.DAO
{
    class DaoEmpresa
    {
        public DaoEmpresa() { 
        }

        public Cliente getInstance(UInt32 idCliente){
           return null;
        }

        static public List<Empresa> getEmpresas(String razonSocial, String eMail, String cuil) {
            List<Empresa> empresas = new List<Empresa>();

            String query = "";
            // razonSocial eMail cuil
            if ((razonSocial == null || razonSocial == "") && (eMail == null || eMail == "") && (cuil == null || cuil == ""))
            {
                query = "select * from DD.Usuario_Empresa";
            }
            else
            {
                //logica para construir la query
                query = "SELECT * FROM DD.usuario_empresa " +
                "where razon_social like '%" + razonSocial + "%' " +
                "and mail like '%" + eMail + "%' " +
                "and cuit like '%" + cuil + "%'";
            }            

            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();

            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    Empresa empresa = new Empresa();
                    Direccion dir = new Direccion();
                    empresa.idEmpresa = rs.GetDecimal(rs.GetOrdinal("id_empresa"));
                    empresa.razonSocial = rs.GetString(rs.GetOrdinal("razon_social"));
                    empresa.nombreContacto = rs.GetString(rs.GetOrdinal("nombre_contacto"));
                    empresa.mail = SQLUtils.SQLUtils.SafeGetString(rs, rs.GetOrdinal("mail"));
                    empresa.fechaCreacion = rs.GetDateTime(rs.GetOrdinal("fecha_creacion"));
                    empresa.cuit = SQLUtils.SQLUtils.SafeGetString(rs, rs.GetOrdinal("cuit"));
                    empresa.telefonos = new DaoTelefono().getTelefonos(empresa);
                    dir.calle = rs.GetString(rs.GetOrdinal("calle"));
                    dir.numero = rs.GetDecimal(rs.GetOrdinal("nro_calle"));
                    dir.piso = rs.GetString(rs.GetOrdinal("piso"));
                    dir.departamento = rs.GetString(rs.GetOrdinal("depto"));
                    dir.codigoPostal= rs.GetString(rs.GetOrdinal("codigo_postal"));
                    dir.ciudad = rs.GetString(rs.GetOrdinal("ciudad"));
                    empresa.direccion = dir;
                    empresas.Add(empresa);
                }

            }
            conn.Close();
            return empresas;
        }

        static public List<Empresa> getAllEmpresas() {
            return getEmpresas(null, null, null);
        }

        static public void persistir(Empresa empresa)
        {
            if (empresa.idEmpresa == 0)
            {
                insertEmpresa(empresa);
            }
            else {
                updateEmpresa(empresa);
            }
                        
        }

        private static void updateEmpresa(Empresa empresa)
        {
            String fecha = empresa.fechaCreacion.ToString("d");

            String sql =
                "update dd.Usuario_Empresa " +
                "set razon_social = '"+empresa.razonSocial+"', " +
                "cuit = '" + empresa.cuit + "', " +
                "mail = '" + empresa.mail + "', " +
                "fecha_creacion = '" + fecha + "', " +
                "nombre_contacto = '" + empresa.nombreContacto + "', " +
                "calle = '" + empresa.direccion.calle+ "', " +
                "nro_calle = '"+empresa.direccion.numero+"', " +
                "piso = '" + empresa.direccion.piso + "', " +
                "depto = '" + empresa.direccion.departamento + "', " +
                "codigo_postal = '" + empresa.direccion.codigoPostal + "', " +
                "ciudad = '" + empresa.direccion.ciudad + "' " +
                "where id_empresa = "+empresa.idEmpresa;

            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            ;
        }

        private static Decimal getProximoIdEmpresa() {
            String query = "select isnull((select MAX(id_empresa)+1), 1) as id_empresa from DD.Usuario_Empresa";
            SqlConnection conn = DBConexion.getConn();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader rs = sql.ExecuteReader();
            Decimal idEmpresa = 0;
            while (rs.Read())
            {
                if (!rs.IsDBNull(0))
                {
                    idEmpresa = rs.GetDecimal(rs.GetOrdinal("id_empresa"));
                }

            }
            conn.Close();
            return idEmpresa;
        }

        private static void insertEmpresa(Empresa empresa)
        {
            String fecha = empresa.fechaCreacion.ToString("d");
            Decimal nuevoIdEmpresa = getProximoIdEmpresa();
            String sql =
            "insert into dd.Usuario_Empresa" +
            "(id_empresa, razon_social, cuit, fecha_creacion," +
            "nombre_contacto, calle, nro_calle," +
            "piso, depto, codigo_postal, ciudad)" +
            "values" +
            "('" + nuevoIdEmpresa + "', " +
            "'" + empresa.razonSocial + "', " +
            "'" + empresa.cuit + "', " +
            "'" + fecha + "', " +
            "'" + empresa.nombreContacto + "', " +
            "'" + empresa.direccion.calle + "', " +
            "'" + empresa.direccion.numero + "', " +
            "'" + empresa.direccion.piso + "', " +
            "'" + empresa.direccion.departamento + "', " +
            "'" + empresa.direccion.codigoPostal + "', " +
            "'" + empresa.direccion.ciudad + "');";
            
            SqlConnection conn = DBConexion.getConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        internal static void eliminar(Empresa empresa)
        {
            String sql =
            "delete from DD.Usuario_Empresa " +
            "where id_empresa = " + empresa.idEmpresa;

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
