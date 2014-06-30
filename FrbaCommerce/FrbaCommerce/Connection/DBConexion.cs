using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Conexion
{
    public class DBConexion
    {
        public static Usuario usuario { get; set; }
        public static Rol rolSeleccionado { get; set; }

        public static SqlConnection getConn()
        {
            SqlConnection conn = new SqlConnection(@"Data source = localhost\SQLSERVER2008; Initial catalog = GD1C2014 ; User Id = gd; Password = gd2014 ");
            conn.Open();
            return conn;
        }

    }
}