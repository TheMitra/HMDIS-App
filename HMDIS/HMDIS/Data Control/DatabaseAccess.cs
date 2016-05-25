using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMDIS.Data_Control
{
    class DatabaseAccess
    {
        public void VisaDatabaseKunder(ListView listViewItem)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\Users\Amandas\Documents\HMDIS-App\HMDIS\HMDIS\Database.mdf'; Integrated Security = True";            
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
            sqlConnection.Open();
            string cmd = "SELECT * FROM Subject;";
            SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);

            // Clear list view, in case a button was pressed to update the list.
            listViewItem.Items.Clear();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                listViewItem.Items.Add(sqlDataReader.GetInt32(0).ToString());
                listViewItem.Items[listViewItem.Items.Count - 1].SubItems.Add(sqlDataReader.GetString(1));
                listViewItem.Items[listViewItem.Items.Count - 1].SubItems.Add(sqlDataReader.GetInt32(2).ToString());
                listViewItem.Items[listViewItem.Items.Count - 1].SubItems.Add(sqlDataReader.GetInt32(3).ToString());
                listViewItem.Items[listViewItem.Items.Count - 1].SubItems.Add(sqlDataReader.GetDecimal(4).ToString());
                listViewItem.Items[listViewItem.Items.Count - 1].SubItems.Add(sqlDataReader.GetString(5));
                listViewItem.Items[listViewItem.Items.Count - 1].SubItems.Add(sqlDataReader.GetString(6));

            }

            sqlConnection.Close();
        }
    }
}
