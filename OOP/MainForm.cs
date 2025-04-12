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
using OOP.Controls;
using OOP.Model;
namespace OOP
{
    public partial class MainForm : MaterialForm
    {
        private int selectedPersonId;
        private int selectedDoctorId;
        private int selectedAngelId;
        private bool isPersonEdit = false;
        private bool isDoctorEdit = false;
        private bool isAngelEdit = false;
        public MainForm()
        {
            InitializeComponent();
        }
        private void ClearUserPage()
        {
            isPersonEdit = false;
            TxtFirst.Text = TxtMiddle.Text = TxtLast.Text = "";
            this.Text = "Manage Person & Patients";
            NumRate.Value = 0;
        }

        private void ClearAngelPage()
        {
            isAngelEdit = false;
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

        private void GetDoctorData(string searchTerm = "")
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DataTables.DoctorList(searchTerm);

                doctorListView.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["autoid"].ToString());
                    item.SubItems.Add(row["firstn"].ToString());
                    item.SubItems.Add(row["middlen"].ToString());
                    item.SubItems.Add(row["lastn"].ToString());
                    item.SubItems.Add(row["Fullname"].ToString());
                    item.SubItems.Add(row["department"].ToString());
                    item.SubItems.Add(row["specialization"].ToString());
                    doctorListView.Items.Add(item);
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
                    item.SubItems.Add(row["name"].ToString());
                    angelListView.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadPatients(string searchTerm = "")
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DataTables.ActivePatientList(searchTerm);

                patientListView.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    

                    ListViewItem item = new ListViewItem(row["autoid"].ToString());
                    item.SubItems.Add(row["person_id"].ToString());
                    item.SubItems.Add(row["doctor_id"].ToString());
                    item.SubItems.Add(row["PersonName"].ToString());
                    item.SubItems.Add(row["DoctorName"].ToString());
                    item.SubItems.Add(row["status"].ToString());
                    item.SubItems.Add(row["diagnose"].ToString());
                    item.SubItems.Add(row["note"].ToString());
                    patientListView.Items.Add(item);
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
            LoadPatients();
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
                if (string.IsNullOrEmpty(TxtAngel.Text))
                {
                    TxtAngel.ErrorMessage = "An Angel name is required!";
                    return;
                }

                using (var conn = new MySqlConnection(ServerInstance.DbConnectionString))
                {
                    string query;

                    if (isAngelEdit)
                    {
                        query = "UPDATE angel_table SET name = @name WHERE autoid = @id";
                    }
                    else
                    {
                        query = "INSERT INTO angel_table (name) VALUES (@name)";
                    }

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", TxtAngel.Text);

                        if (isAngelEdit)
                        {
                            cmd.Parameters.AddWithValue("@id", selectedAngelId);
                        }

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Successfully saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAngelData();
                ClearAngelPage();
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
                this.Text = $"Editing Angel with Id: {selectedAngelId.ToString()}";
                TxtAngel.Text = angelListView.SelectedItems[0].SubItems[1].Text.ToString();
            } 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectedAngelId = Convert.ToInt32(angelListView.SelectedItems[0].SubItems[0].Text);

            var result = MessageBox.Show("Do you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new MySqlConnection(ServerInstance.DbConnectionString))
                    {
                        conn.Open(); 

                        using (var cmd = new MySqlCommand("DELETE FROM angel_table WHERE autoid = @id", conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedAngelId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    GetAngelData();
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
                this.Text = $"Editing Person with Id: {selectedPersonId.ToString()}";
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

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                FrmConnect frm = new FrmConnect();
                frm.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tabPage1)
            {
                GetPersonData();
                this.Text = "Manage Person & Patients";
                LoadPatients();
            }
            else if (materialTabControl1.SelectedTab == tabPage2)
            {
                GetDoctorData();
                this.Text = "Manage Doctors";
            }
            else if (materialTabControl1.SelectedTab == tabPage3)
            {
                GetAngelData();
                this.Text = "Manage Angels";

            }
        }

        private void materialCard4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doctorListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearDoctorPage()
        {
            DocFirstname.Text = DocMiddlename.Text = DocLastn.Text = DocDept.Text = DocSpecial.Text = DocSearch.Text = "";
            this.Text = "Manage Doctors";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                bool isValid = Functions.ValidateFields(errorProvider1, (DocFirstname, "A Firstname is required"), (DocMiddlename, "A Middlename is required"), (DocSpecial, "A Last name is required"), (DocDept, "A Department is required"), (DocSpecial, "A Specialization is required"));
                if (isValid)
                {
                    using (var conn = new MySqlConnection(ServerInstance.DbConnectionString))
                    {
                        var cmdString = isDoctorEdit ? "Update doctor_table SET firstn = @firstn, middlen = @middlen, lastn = @lastn, department = @dept, specialization = @special WHERE autoid = @id" : "INSERT INTO doctor_table(firstn, middlen, lastn, department, specialization) VALUES(@firstn, @middlen, @lastn, @dept, @special)";

                        using (var cmd = new MySqlCommand(cmdString, conn))
                        {
                            if (isDoctorEdit)
                            {
                                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = selectedDoctorId;
                            }

                            cmd.Parameters.Add("@firstn", MySqlDbType.Text).Value = DocFirstname.Text;
                            cmd.Parameters.Add("@middlen", MySqlDbType.Text).Value = DocMiddlename.Text;
                            cmd.Parameters.Add("@lastn", MySqlDbType.Text).Value = DocLastn.Text;
                            cmd.Parameters.Add("@dept", MySqlDbType.Text).Value = DocDept.Text;
                            cmd.Parameters.Add("@special", MySqlDbType.Text).Value = DocSpecial.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Successfully saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetDoctorData();
                    ClearDoctorPage();
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

        private void button15_Click(object sender, EventArgs e)
        {
            if (doctorListView.SelectedItems.Count > 0)
            {
                isDoctorEdit = true;
                selectedDoctorId = Convert.ToInt32(doctorListView.SelectedItems[0].SubItems[0].Text);
                this.Text = $"Editing Details of : {doctorListView.SelectedItems[0].SubItems[4].Text}";
                DocFirstname.Text = doctorListView.SelectedItems[0].SubItems[1].Text.ToString();
                DocMiddlename.Text = doctorListView.SelectedItems[0].SubItems[2].Text.ToString();
                DocLastn.Text = doctorListView.SelectedItems[0].SubItems[3].Text.ToString();
                DocDept.Text = doctorListView.SelectedItems[0].SubItems[5].Text.ToString();
                DocSpecial.Text = doctorListView.SelectedItems[0].SubItems[6].Text.ToString();
            }
            else
            {
                MessageBox.Show("Please select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (doctorListView.SelectedItems.Count > 0)
            {
                selectedDoctorId = Convert.ToInt32(doctorListView.SelectedItems[0].SubItems[0].Text);

                var result = MessageBox.Show("Do you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var conn = new MySqlConnection(ServerInstance.DbConnectionString))
                        {
                            using (var cmd = new MySqlCommand("DELETE FROM doctor_table WHERE autoid = @id", conn))
                            {

                                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = selectedDoctorId;
                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }

                        GetDoctorData();
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

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        
        private void button13_Click(object sender, EventArgs e)
        {
            if (personListView.SelectedItems.Count > 0)
            {
                AdmitPerson form = new AdmitPerson();
                form.SetDependencies(Convert.ToInt32(personListView.SelectedItems[0].SubItems[0].Text));
                form.OnPatientSaved += () => LoadPatients();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (patientListView.SelectedItems.Count > 0)
            {
                Doctor newDoctor = new Doctor();
                newDoctor.DischargePatient(Convert.ToInt32(patientListView.SelectedItems[0].SubItems[0].Text));
                LoadPatients();
            }
            else
            {
                MessageBox.Show("Please select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PatientSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPatients(PatientSearch.Text);
        }

        private void DocSearch_TextChanged(object sender, EventArgs e)
        {
            GetDoctorData(TxtSearch.Text);
        }

        private void AngelSearch_TextChanged(object sender, EventArgs e)
        {
            GetAngelData(AngelSearch.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (patientListView.SelectedItems.Count > 0)
            {
                Doctor newDoctor = new Doctor();
                newDoctor.AscendToHeaven(Convert.ToInt32(patientListView.SelectedItems[0].SubItems[0].Text));
                LoadPatients();
            }
            else
            {
                MessageBox.Show("Please select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
