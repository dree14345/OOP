using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Core
{
    public class DataTables
    {
        public static DataTable PersonList(string searchTerm = "")
        {
            try
            {
                DataTable dt = new DataTable();

                using (MySqlConnection conn = new MySqlConnection(ServerInstance.DbConnectionString))
                {
                    conn.Open(); 

                    using (MySqlCommand storedProc = new MySqlCommand("GetAllPersonData", conn))
                    {
                        storedProc.CommandType = CommandType.StoredProcedure;

                        storedProc.Parameters.AddWithValue("@search_term", searchTerm);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(storedProc))
                        {
                            adapter.Fill(dt);  
                        }
                    }
                }

                return dt;  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; 
            }
        }

        public static DataTable AngelList(string searchTerm = "")
        {
            try
            {
                DataTable dt = new DataTable();

                using (MySqlConnection conn = new MySqlConnection(ServerInstance.DbConnectionString))
                {
                    conn.Open();

                    using (MySqlCommand storedProc = new MySqlCommand("GetAngelData", conn))
                    {
                        storedProc.CommandType = CommandType.StoredProcedure;

                        storedProc.Parameters.AddWithValue("@search_term", searchTerm);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(storedProc))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }


}
