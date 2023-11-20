using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    internal class dbCRUD
    {
        public void InsertOpenDoorRecord(int floorNumber, string actionLog)
        {
            string connectionString = "datasource=localhost; Database=elevator; port=3306; User=root; Password=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT IGNORE INTO elevator (floor_number,open_date, open_time, action_log) VALUES (@floor, NOW(), NOW(), @actionLog)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@floor", floorNumber);
                    cmd.Parameters.AddWithValue("@actionLog", actionLog);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateDatalog(DataGridView logTable)
{
    string connectionString = "datasource=localhost; Database=elevator; port=3306; User=root; Password=root";
    string query = "SELECT floor_number, open_date, open_time, action_log FROM elevator";

    using (MySqlConnection connection = new MySqlConnection(connectionString))
    {
        using (MySqlCommand command = new MySqlCommand(query, connection))
        {
            connection.Open();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataTable.Columns["floor_number"].ColumnName = "Floor Number";
                dataTable.Columns["open_date"].ColumnName = "Open Date";
                dataTable.Columns["open_time"].ColumnName = "Open Time";
                dataTable.Columns["action_log"].ColumnName = "Action Log";

                logTable.DataSource = dataTable;

                if (logTable.Rows.Count > 0)
                {
                    logTable.FirstDisplayedScrollingRowIndex = logTable.Rows.Count - 1;
                }
            }
        }
    }
}


        public void deleteRecords()
        {
            string connectionString = "datasource=localhost; Database=elevator; port=3306; User=root; Password=root";
            string query = "DELETE FROM elevator";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Records deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No records matched the delete condition.");
                    }
                }
            }
        }
    }
}
