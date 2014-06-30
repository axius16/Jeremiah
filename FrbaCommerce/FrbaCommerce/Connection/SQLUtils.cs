using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System;
namespace FrbaCommerce.SQLUtils
{
    public class SQLUtils
    {        
        public static void cargarTabla(DataGridView dataGridView, IList coleccion)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = coleccion;
            dataGridView.Refresh();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false; 
            dataGridView.ClearSelection();
        }

        public static string SafeGetString(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            else
                return string.Empty;
        }

        public static Decimal? SafeGetDecimal(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetDecimal(colIndex);
            else
                return null;
        }

    }
}