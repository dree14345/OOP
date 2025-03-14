using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Model;
using OOP.Controls;

namespace OOP
{
    public partial class Form1 : Form
    {
        Person[] newPerson = new Person[5];
        Doctor newDoc = new Doctor();
        int counter = 0;
        private bool isUpdate = false;
        private int selectedIndex = -1; // Track selected index

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private bool ValidateFields()
        {
            bool isError = false;

            if (string.IsNullOrEmpty(TxtFirst.Text))
            {
                personError.SetError(TxtFirst, "Firstname is required");
                isError = true;
            }
            else
            {
                personError.SetError(TxtFirst, "");
            }

            if (string.IsNullOrEmpty(TxtMiddle.Text))
            {
                personError.SetError(TxtMiddle, "Middlename is required");
                isError = true;
            }
            else
            {
                personError.SetError(TxtMiddle, "");
            }

            if (string.IsNullOrEmpty(TxtLast.Text))
            {
                personError.SetError(TxtLast, "Lastname is required");
                isError = true;
            }
            else
            {
                personError.SetError(TxtLast, "");
            }

            return !isError;
        }


        private void Clear()
        {
            personError.Clear();
            TxtFirst.Text = "";
            TxtMiddle.Text = "";
            TxtLast.Text = "";
            TxtFirst.Focus();
            button1.Text = "Save"; // Reset button text
            isUpdate = false;
            selectedIndex = -1; // Reset selected index
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ValidateFields();
            bool notError = ValidateFields();
            if (notError)
            {
                if (!isUpdate)
                {
                    // Insert new record
                    if (counter < newPerson.Length)
                    {
                        newPerson[counter] = new Person();
                        newPerson[counter].setFirstName = TxtFirst.Text;
                        newPerson[counter].setMiddleName = TxtMiddle.Text;
                        newPerson[counter].setLastName = TxtLast.Text;

                        counter++;
                        //MessageBox.Show($"Array count is: {counter}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Array is full", "Error");
                    }
                }
                else
                {
                    // Update existing record
                    if (MessageBox.Show("Do you want to continue editing this item?", "Edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (selectedIndex >= 0 && selectedIndex < counter)
                        {
                            newPerson[selectedIndex].setFirstName = TxtFirst.Text;
                            newPerson[selectedIndex].setMiddleName = TxtMiddle.Text;
                            newPerson[selectedIndex].setLastName = TxtLast.Text;
                        }
                    }
                    else
                    {
                        return;
                    }


                }
                PopulateListView();
                populateConfinedList();
                Clear();
            } else
            {
                MessageBox.Show("Please enter required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateListView(string searchTerm = "")
        {
            personListView.Items.Clear();

            for (int i = 0; i < counter; i++)
            {
                // Check if the search term exists in any of the name fields
                if (string.IsNullOrEmpty(searchTerm) ||
                    newPerson[i].getFirstName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    newPerson[i].getMiddleName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    newPerson[i].getLastName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = newPerson[i].getFirstName;
                    item.SubItems.Add(newPerson[i].getMiddleName);
                    item.SubItems.Add(newPerson[i].getLastName);
                    personListView.Items.Add(item);
                }
            }
        }

        private void populateConfinedList(string searchTerm = "")
        {
            confinedList.Items.Clear();  // Clear the list to ensure it's freshly populated

            var hospitalizedPatients = newDoc.GetHospitalizedPatients();  // Get the hospitalized patients

            foreach (var patient in hospitalizedPatients)
            {
                if (patient != null)
                {
                    if (string.IsNullOrEmpty(searchTerm) ||
                        patient.getFirstName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        patient.getMiddleName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        patient.getLastName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = patient.getFullName;  // Add full name
                        item.SubItems.Add(patient.getHeartRate.ToString());  // Add heart rate
                        item.SubItems.Add(patient.getTemperature.ToString());  // Add temperature
                        confinedList.Items.Add(item);  // Add item to confined list
                    }
                }
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void personListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (personListView.SelectedItems.Count > 0)
            {
                selectedIndex = personListView.SelectedIndices[0];

                for (int i = selectedIndex; i < counter - 1; i++)
                {
                    newPerson[i] = newPerson[i + 1];
                }
                newPerson[counter - 1] = null;

                counter--;
                PopulateListView();
                populateConfinedList();
                Clear();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (personListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = personListView.SelectedItems[0];
                selectedIndex = personListView.SelectedIndices[0]; // Get the selected index

                //MessageBox.Show($"The Selected Index is {selectedIndex}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtFirst.Text = selectedItem.SubItems[0].Text;
                TxtMiddle.Text = selectedItem.SubItems[1].Text;
                TxtLast.Text = selectedItem.SubItems[2].Text;

                isUpdate = true;
                button1.Text = "Update"; // Change button text to "Update"
            }
        }

        private void TxtLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (personListView.SelectedItems.Count > 0)
            {
                selectedIndex = personListView.SelectedIndices[0]; // Get the selected index

                // Check if the selected index has a valid Person  
                if (selectedIndex >= 0 && selectedIndex < newPerson.Length && newPerson[selectedIndex] != null)
                {
                    newDoc.HospitalizePatient(selectedIndex, newPerson);  // Hospitalize the selected patient
                    populateConfinedList();  // Update the confined list to reflect hospitalized patients
                    Clear();  // Reset form
                }
                else
                {
                    MessageBox.Show("Please select a valid person first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void button5_Click(object sender, EventArgs e)
        {
            if (confinedList.SelectedItems.Count > 0)
            {
                selectedIndex = confinedList.SelectedIndices[0]; // Get the selected index

                if (selectedIndex >= 0 && selectedIndex < newPerson.Length && newPerson[selectedIndex] != null)
                {
                    // Show input dialog for heart rate
                    string input = Prompt.ShowDialog("Enter Heart Rate:", "Heart Rate Input");

                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int heartRate))
                    {
                        newDoc.SetHeartRate(selectedIndex, heartRate);  // Use newDoc to update heart rate
                        populateConfinedList();  // Update the confined list
                        Clear();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid heart rate input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (confinedList.SelectedItems.Count > 0)
            {
                selectedIndex = confinedList.SelectedIndices[0]; // Get the selected index


                if (selectedIndex >= 0 && selectedIndex < newPerson.Length && newPerson[selectedIndex] != null)
                {
                    // Show input dialog for temperature
                    string input = Prompt.ShowDialog("Enter Temperature:", "Temperature Input");

                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int temperature))
                    {
                        newDoc.SetTemperature(selectedIndex, temperature); 
                        populateConfinedList();  // Update the confined list
                        Clear();
                       
                    }
                    else
                    {
                        MessageBox.Show("Invalid temperature input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void confinedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

		private void button8_Click(object sender, EventArgs e)
		{
			if (confinedList.SelectedItems.Count > 0)
			{
				selectedIndex = confinedList.SelectedIndices[0]; // Get the selected index


				if (selectedIndex >= 0 && selectedIndex < newPerson.Length && newPerson[selectedIndex] != null)
				{
					// Show input dialog for temperature
					string input = Prompt.ShowDialog("Enter the name of the person authorized the discharge procedures", "Angel Name");

					if (!string.IsNullOrEmpty(input))
					{

						newDoc.DischargePatient(selectedIndex, input);
						populateConfinedList();  // Update the confined list
						Clear();

					}
					else
					{
						MessageBox.Show("Please enter names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Please select an item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
            newDoc.Guide();
		}

		private void button10_Click(object sender, EventArgs e)
		{
            newDoc.Empower();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (confinedList.SelectedItems.Count > 0)
			{
				selectedIndex = confinedList.SelectedIndices[0]; // Get the selected index


				if (selectedIndex >= 0 && selectedIndex < newPerson.Length && newPerson[selectedIndex] != null)
				{
					// Show input dialog for temperature
					newDoc.RescuePatient(selectedIndex);
					populateConfinedList();  // Update the confined list
					Clear();
				}
			}
			else
			{
				MessageBox.Show("Please select an item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
