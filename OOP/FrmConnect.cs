using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Properties;
using MySql.Data.MySqlClient;
using OOP.Core;

namespace OOP
{
    public partial class FrmConnect : MaterialForm
    {
        public FrmConnect()
        {
            InitializeComponent();
        }

        private void FrmConnect_Load(object sender, EventArgs e)
        {

        }

        private void FrmConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to close this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            } else
            {
                e.Cancel = true;
            }
        }

        private void ConnectToDatabase(string server, string db, string port, string user, string pass)
        {
            // Validation Dictionary
            var validationErrors = new Dictionary<MaterialTextBox2, string>
            {
                { TxtServer, "Server name is required" },
                { TxtDb, "Database name is required" },
                { TxtPort, "Port is required" },
                { TxtUser, "Username is required" },
            };

            // Collect errors
            bool isValid = true;
            foreach (var entry in validationErrors)
            {
                if (string.IsNullOrWhiteSpace(entry.Key.Text))
                {
                    entry.Key.ErrorMessage = entry.Value;
                    isValid = false;
                }
            }

            if (!isValid)
            {
                MessageBox.Show("Please fill all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save settings
            Settings.Default.Server = server;
            Settings.Default.DB = db;
            Settings.Default.Port = port;
            Settings.Default.User = user;
            Settings.Default.Pass = pass;
            Settings.Default.Save();

            try
            {
                using (var con = new MySqlConnection(ServerInstance.DbConnectionString))
                {
                    con.Open();
                    MessageBox.Show($"Successfully connected to the database {db}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainForm form = new MainForm();
                    form.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed!\nError: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            ConnectToDatabase(TxtServer.Text, TxtDb.Text, TxtPort.Text, TxtUser.Text, TxtPass.Text);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            TxtServer.Text = "localhost";
            TxtDb.Text = "oopdb";
            TxtPort.Text = "3306";
            TxtUser.Text = "root";
            TxtPass.Text = "";
            ConnectToDatabase(TxtServer.Text, TxtDb.Text, TxtPort.Text, TxtUser.Text, TxtPass.Text);
        }
    }
}
