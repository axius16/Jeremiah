using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
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

    }
}