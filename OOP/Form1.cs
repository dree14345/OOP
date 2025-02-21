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

namespace OOP
{
    public partial class Form1 : Form
    {
        Person[] newPerson = new Person[5];
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

        private void ValidateFields()
        {
            personError.SetError(TxtFirst, string.IsNullOrEmpty(TxtFirst.Text) ? "Firstname is required" : "");
            personError.SetError(TxtMiddle, string.IsNullOrEmpty(TxtMiddle.Text) ? "Middlename is required" : "");
            personError.SetError(TxtLast, string.IsNullOrEmpty(TxtLast.Text) ? "Lastname is required" : "");
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
                    MessageBox.Show($"Array count is: {counter}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateListView();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Array is full", "Error");
                }
            }
            else
            {
                // Update existing record
                if (selectedIndex >= 0 && selectedIndex < counter)
                {
                    newPerson[selectedIndex].setFirstName = TxtFirst.Text;
                    newPerson[selectedIndex].setMiddleName = TxtMiddle.Text;
                    newPerson[selectedIndex].setLastName = TxtLast.Text;
                    PopulateListView();
                    Clear();
                }
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



        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void personListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = personListView.SelectedItems[0];
                selectedIndex = personListView.SelectedIndices[0]; // Get the selected index

                MessageBox.Show($"The Selected Index is {selectedIndex}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtFirst.Text = selectedItem.SubItems[0].Text;
                TxtMiddle.Text = selectedItem.SubItems[1].Text;
                TxtLast.Text = selectedItem.SubItems[2].Text;

                isUpdate = true;
                button1.Text = "Update"; // Change button text to "Update"
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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
                Clear();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Error");
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtSearch.Text))
            {
                PopulateListView(TxtSearch.Text);
            } else
            {
                PopulateListView();
            }
        }
    }
}
