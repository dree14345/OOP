using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using OOP.Core;
using OOP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Controls
{
    public partial class AdmitPerson : MaterialForm
    {
        private int _personId;
        public event Action OnPatientSaved;

        public AdmitPerson()
        {
            InitializeComponent();
        }

        public void SetDependencies(int personId)
        {
            if (personId == 0)
            {
                MessageBox.Show("No person selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            _personId = personId;
            this.Text = $"Admit Person with ID: {personId}";
        }

        private void Clear()
        {
            this.Text = "Admit Patient";
            _personId = 0;
            SelectDoctor.SelectedIndex = -1;
            TxtDiagnosis.Text = TxtNotes.Text = "";
        }

        private void LoadDoctors()
        {
            SelectDoctor.DataSource = DataTables.DoctorList();
            SelectDoctor.ValueMember = "autoid";
            SelectDoctor.DisplayMember = "Fullname";
            SelectDoctor.SelectedIndex = -1; // Set AFTER data binding
        }

        private void AdmitPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Optional: You may handle cleanup here
            Clear();
            MainForm form = new MainForm();
            form.LoadPatients();
        }

        private void AdmitPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void AdmitPerson_Load(object sender, EventArgs e)
        {
            LoadDoctors();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                bool isValid = Functions.ValidateFields(
                    errorProvider1,
                    (SelectDoctor, "You need to select a doctor"),
                    (TxtDiagnosis, "Input your diagnosis of the patient"),
                    (TxtNotes, "Enter Notes regarding the Patient")
                );

                if (!isValid)
                    return;

                Doctor newDoc = new Doctor();
                newDoc.AdmitPatient(_personId, Convert.ToInt32(SelectDoctor.SelectedValue), TxtDiagnosis.Text, TxtNotes.Text);


                MessageBox.Show("Patient saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
