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
using System.Net.NetworkInformation;

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

        private void ConnectToDatabase()
        {

            bool isValid = true;



            if (string.IsNullOrEmpty(TxtServer.Text))
            {
                TxtServer.ErrorMessage = "Server name is required";
                isValid = false;
            } else if (string.IsNullOrEmpty(TxtDb.Text))
            {
                TxtDb.ErrorMessage = "Database name is required";
                isValid = false;
            }
            else if (string.IsNullOrEmpty(TxtPort.Text))
            {
                TxtPort.ErrorMessage = "Port is required";
                isValid = false;
            }
            else if (string.IsNullOrEmpty(TxtUser.Text))
            {
                TxtUser.ErrorMessage = "Username is required";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Please fill all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var ping = new Ping();
            var pingReply = ping.Send(TxtServer.Text);
            // Save settings
            if (pingReply != null && pingReply.Status == IPStatus.Success)
            {
                Settings.Default.Server = TxtServer.Text;
                Settings.Default.DB = TxtDb.Text;
                Settings.Default.Port = TxtPort.Text;
                Settings.Default.User = TxtUser.Text;
                Settings.Default.Pass = TxtPass.Text;
                Settings.Default.Save();

                try
                {
                    using (var con = new MySqlConnection(ServerInstance.DbConnectionString))
                    {
                        con.Open();
                        MessageBox.Show($"Successfully connected to the database {TxtDb.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }




        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            ConnectToDatabase();
        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            TxtServer.Text = "localhost";
            TxtDb.Text = "oopdb";
            TxtPort.Text = "3306";
            TxtUser.Text = "root";
            TxtPass.Text = "1234567";
            ConnectToDatabase();
        }
    }
}
