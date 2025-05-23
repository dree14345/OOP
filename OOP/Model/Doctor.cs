﻿using MySql.Data.MySqlClient;
using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Model
{
    public class Doctor : Angel
    {
        Person[] newPerson = new Person[5];


        public void SetHeartRate(int index, int heartRate)
        {
            
            if (index >= 0 && index < newPerson.Length )
            {
                newPerson[index].setHeartRate = heartRate;  // Update heart rate
            }
        }

        public void SetHeartRate()
        {
            MessageBox.Show("Invalid Data. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void SetTemperature(int index, int temperature)
        {
            
            
            if (index >= 0 && index < newPerson.Length && newPerson[index] != null)
            {
                newPerson[index].setTemperature = temperature;  // Update temperature
            }
        }




        public void HospitalizePatient(int index, Person[] p)
        {
            // Ensure that the index is valid and the person exists in the source array 'p'
            if (index >= 0 && index < p.Length && p[index] != null)
            {
                // Find the next available index in the 'newPerson' array
                int nextAvailableIndex = Array.FindIndex(newPerson, person => person == null);

                // If there is an available spot in the 'newPerson' array
                if (nextAvailableIndex >= 0)
                {
                    // Assign the person at 'index' in 'p' to the next available spot in 'newPerson'
                    newPerson[nextAvailableIndex] = p[index];

                    // Update the hospitalized status of the person in 'newPerson'
                    newPerson[nextAvailableIndex].setIsHospitalized = true;

                    MessageBox.Show($"Patient {newPerson[nextAvailableIndex].getFullName} has been hospitalized.");
                }
                else
                {
                    // If 'newPerson' array is full
                    MessageBox.Show("No available space to hospitalize more patients.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid index or person data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void DischargePatient(int index, string authorization)
        {
            
            if (index >= 0 && index < newPerson.Length && newPerson[index] != null)
            {
                String patientName = newPerson[index].getFullName;
                bool isDischarge = authorizeDischarge(authorization);
                if (isDischarge)
                {

                    newPerson[index] = null;
                    MessageBox.Show($"{patientName} is now discharged by Angel {authorization}", "Successfully Discharged", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        public void Ascend(int index)
        {
			Random rand = new Random();
			int angelIndex = rand.Next(angelNames.Length - 1);
			string randomAngel = angelNames[angelIndex];


			if (index >= 0 && index < newPerson.Length && newPerson[index] != null)
			{
				String patientName = newPerson[index].getFullName;
				for (int i = index; i < newPerson.Length - 1; i++)
				{
					newPerson[index] = newPerson[index + 1];
				}

				newPerson[index] = null;
				MessageBox.Show($"{patientName} is ascended by Angel {randomAngel}", "Successfully Discharged", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
        public Person[] GetHospitalizedPatients()
        {
            return newPerson
            .Where(p => p != null && p.getIsHospitalized)  // Filter out null objects and hospitalized patients
            .ToArray();
        }
        public void RescuePatient(int index)
        {
            Rescue(newPerson, index);  // Pass newPerson array to Angel's Rescue method
        }

        public void SetWeight(int index, int weight, Person[] p)
        {
            if (index >= 0 && index <= newPerson.Length && newPerson[index] != null)
            {
                newPerson[index].SetWeight = weight;
            }
        }


        public void AdmitPatient(int personId, int doctorId, string diagnose, string notes)
        {
            using (var conn = new MySqlConnection(ServerInstance.DbConnectionString))
            {
                using (var cmd = new MySqlCommand("INSERT INTO patient_table(person_id, doctor_id, diagnose, note) VALUES(@person_id, @doctor_id, @diagnose, @note)", conn))
                {
                    cmd.Parameters.AddWithValue("@person_id", personId);
                    cmd.Parameters.AddWithValue("@doctor_id", doctorId);
                    cmd.Parameters.AddWithValue("@diagnose", diagnose);
                    cmd.Parameters.AddWithValue("@note", notes);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DischargePatient(int autoid)
        {
            try
            {
                using (var conn = new MySqlConnection(ServerInstance.DbConnectionString))
                {
                    using (var cmd = new MySqlCommand("UPDATE patient_table SET status = @status WHERE autoid = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@status", "Discharged");
                        cmd.Parameters.AddWithValue("@id", autoid);

                        conn.Open();
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows == 0)
                        {
                            MessageBox.Show("No patient was found with the given ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        MessageBox.Show("Successfully Discharge the Patient", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while discharging patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
