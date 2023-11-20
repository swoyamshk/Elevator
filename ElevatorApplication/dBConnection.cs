using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    internal class dBConnection
    {
        private static void datbaseConnection()
        {
            //Connect DB
            string url = "datasource=localhost; Database=elevator ; port=3306; User=root; Password=root";
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
                conn.Close();
                MessageBox.Show("Connect with database server successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
