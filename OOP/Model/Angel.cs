using MySql.Data.MySqlClient;
using OOP.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Model
{
    public class Angel
    {

		public string[] angelNames = {
	"Abatur", "Abbadon", "Abdiel", "Adathan", "Adriel", "Agiel", "Ananiel", "Anush",
	"Arakiel", "Arariel", "Ariel", "Armaros", "Artiyail", "Asbeel", "Azazel", "Azrael",
	"Barachiel", "Baraqiel", "Barbiel", "Beburos", "Gabriel", "Mael", "Michael", "Bezaliel"
         };


        public Boolean authorizeDischarge(String name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                MessageBox.Show($"You are now discharged with authorization from Angel {name}", "Discharged Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }



        public void Guide()
        {
            Random rand = new Random();
            int index = rand.Next(angelNames.Length - 1);
            string randomAngel = angelNames[index];
            MessageBox.Show($"You have been guided by Angel {randomAngel}", "Blessed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Empower()
        {
            Random rand = new Random();
            int index = rand.Next(angelNames.Length - 1);
            string randomAngel = angelNames[index];
            MessageBox.Show($"You have been empowered by Angel {randomAngel}", "Blessed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void Observe()
        {
            Random rand = new Random();
            int index = rand.Next(angelNames.Length - 1);
            string randomAngel = angelNames[index];
            MessageBox.Show($"You have been observed by Angel {randomAngel}", "Blessed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Rescue(Person[] patients, int index)
        {
            if (index >= 0 && index < patients.Length && patients[index] != null)
            {
                Random rand = new Random();
                int angelIndex = rand.Next(angelNames.Length);
                string randomAngel = angelNames[angelIndex];

                string patientName = patients[index].getFullName;
                patients[index] = null; // Remove the patient

                MessageBox.Show($"Patient {patientName} has been rescued by Angel {randomAngel}", "Rescued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AscendToHeaven(int autoid)
        {
            string angelName = "";
            string patientName = "";

            using (var conn = new MySqlConnection(ServerInstance.DbConnectionString))
            {
                conn.Open();

                // Call GetRandomAngel
                using (var cmd = new MySqlCommand("CALL GetRandomAngel()", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        angelName = reader.GetString("name");
                }

                // Call AscendPatientToHeaven
                using (var cmd = new MySqlCommand("CALL AscendPatientToHeaven(@patient_autoid)", conn))
                {
                    cmd.Parameters.AddWithValue("@patient_autoid", autoid);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            patientName = reader.GetString("fullname");
                    }
                }

                // Show result
                MessageBox.Show($"Successfully ascended patient {patientName} to heaven by Angel {angelName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void Blessed(int autoid)
        {

        }

    }
}
