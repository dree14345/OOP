using System;
using MySql.Data.MySqlClient;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Core;
using MaterialSkin.Controls;
namespace OOP
{
    public partial class MainForm : MaterialForm
    {
        private int selectedPersonId;
        private int selectedAngelId;
        private bool isPersonEdit = false;
        private bool isAngelEdit = false;
        public MainForm()
        {
            InitializeComponent();
        }
        private void ClearUserPage()
        {
            isPersonEdit = false;
            TxtMode.Text = "Adding Users";
            TxtFirst.Text = TxtMiddle.Text = TxtLast.Text = "";
            NumRate.Value = 0;
        }

        private void ClearAngelPage()
        {
            isAngelEdit = false;
            TxtMode1.Text = "Adding Angel";
            TxtAngel.Text = AngelSearch.Text = "";
        }

        private void GetPersonData(string searchTerm = "")
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DataTables.PersonList(searchTerm);

                personListView.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //ListViewItem item = personListView.Items.Add(row[0] != null ? row[0].ToString() : string.Empty);
                    //for (int i = 1; i < dt.Columns.Count; i++)
                    //{
                    //    item.SubItems.Add(row[i] != null ? row[i].ToString() : string.Empty);
                    //}

                    ListViewItem item = new ListViewItem(row["autoid"].ToString());
                    item.SubItems.Add(row["firstn"].ToString());
                    item.SubItems.Add(row["middlen"].ToString());
                    item.SubItems.Add(row["lastn"].ToString());
                    item.SubItems.Add(row["heart_rate"].ToString());
                    personListView.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GetAngelData(string searchTerm = "")
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DataTables.AngelList(searchTerm);

                angelListView.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //ListViewItem item = personListView.Items.Add(row[0] != null ? row[0].ToString() : string.Empty);
                    //for (int i = 1; i < dt.Columns.Count; i++)
                    //{
                    //    item.SubItems.Add(row[i] != null ? row[i].ToString() : string.Empty);
                    //}

                    ListViewItem item = new ListViewItem(row["autoid"].ToString());
                    item.SubItems.Add(row["angel_name"].ToString());
                    angelListView.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            GetPersonData();
            GetAngelData();
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void personListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = false;

                if (!String.IsNullOrEmpty(TxtAngel.Text))
                {
                    isValid = true;
                } else
                {
                    TxtAngel.ErrorMessage = "An Angel name is required!";
                    return;
                }

                if (isValid)
                {
                    using (var conn = new MySqlConnection(ServerInstance.DbConnectionString))
                    {
                        var storedProcName = isAngelEdit ? "UpdateAngel" : "CreateAngel";

                        using (var storedProc = new MySqlCommand(storedProcName, conn)
                        {
                            CommandType = CommandType.StoredProcedure,
                        })
                        {

                            if (isAngelEdit)
                            {
                                storedProc.Parameters.Add("@_id", MySqlDbType.Int32).Value = selectedAngelId;
                            }

                            storedProc.Parameters.Add("@_name", MySqlDbType.Text).Value = TxtAngel.Text;
                            conn.Open();
                            storedProc.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Successfully saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAngelData();
                    ClearAngelPage();

                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (angelListView.SelectedItems.Count > 0) {
                isAngelEdit = true;
                selectedAngelId = Convert.ToInt32(angelListView.SelectedItems[0].SubItems[0].Text);
                TxtMode1.Text = $"Editing Angel with Id: {selectedAngelId.ToString()}";
                TxtAngel.Text = angelListView.SelectedItems[0].SubItems[1].Text.ToString();
            } 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectedAngelId = Convert.ToInt32(personListView.SelectedItems[0].SubItems[0].Text);

            var result = MessageBox.Show("Do you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new MySqlConnection(ServerInstance.DbConnectionString))
                    {
                        using (var storedProc = new MySqlCommand("DeleteAngel", conn)
                        {
                            CommandType = CommandType.StoredProcedure,
                        })
                        {
                            storedProc.Parameters.Add("@_id", MySqlDbType.Int32).Value = selectedPersonId;
                            conn.Open();
                            storedProc.ExecuteNonQuery();
                        }
                    }

                    GetPersonData();
                    MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            ClearAngelPage();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (personListView.SelectedItems.Count > 0)
            {
                selectedPersonId = Convert.ToInt32(personListView.SelectedItems[0].SubItems[0].Text);

                var result = MessageBox.Show("Do you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var conn = new MySqlConnection(ServerInstance.DbConnectionString))
                        {
                            using (var storedProc = new MySqlCommand("DeletePerson", conn)
                            {
                                CommandType = CommandType.StoredProcedure,
                            })
                            {
                                storedProc.Parameters.Add("@id", MySqlDbType.Int32).Value = selectedPersonId;
                                conn.Open();
                                storedProc.ExecuteNonQuery();
                            }
                        }

                        GetPersonData();
                        MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                bool isValid = Functions.ValidateFields(errorProvider1, (TxtFirst, "A Firstname is required"), (TxtMiddle, "A Middlename is required"), (TxtLast, "A Last name is required"), (NumRate, "A Heart rate is required"));
                if (isValid)
                {
                    using (var conn = new MySqlConnection(ServerInstance.DbConnectionString))
                    {
                        var storedProcName = isPersonEdit ? "UpdatePerson" : "CreatePerson";

                        using (var storedProc = new MySqlCommand(storedProcName, conn)
                        {
                            CommandType = CommandType.StoredProcedure,
                        })
                        {

                            if (isPersonEdit)
                            {
                                storedProc.Parameters.Add("@id", MySqlDbType.Int32).Value = selectedPersonId;
                            }

                            storedProc.Parameters.Add("@f_name", MySqlDbType.Text).Value = TxtFirst.Text;
                            storedProc.Parameters.Add("@m_name", MySqlDbType.Text).Value = TxtMiddle.Text;
                            storedProc.Parameters.Add("@l_name", MySqlDbType.Text).Value = TxtLast.Text;
                            storedProc.Parameters.Add("@heart_rate", MySqlDbType.Int32).Value = Convert.ToInt32(NumRate.Value);
                            conn.Open();
                            storedProc.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Successfully saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPersonData();
                    ClearUserPage();
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (personListView.SelectedItems.Count > 0)
            {
                isPersonEdit = true;
                selectedPersonId = Convert.ToInt32(personListView.SelectedItems[0].SubItems[0].Text);
                TxtMode.Text = $"Editing Person with Id: {selectedPersonId.ToString()}";
                TxtFirst.Text = personListView.SelectedItems[0].SubItems[1].Text.ToString();
                TxtMiddle.Text = personListView.SelectedItems[0].SubItems[2].Text.ToString();
                TxtLast.Text = personListView.SelectedItems[0].SubItems[3].Text.ToString();
                NumRate.Value = Convert.ToInt32(personListView.SelectedItems[0].SubItems[4].Text);
            }
            else
            {
                MessageBox.Show("Please select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ClearUserPage();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            GetPersonData(TxtSearch.Text);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
