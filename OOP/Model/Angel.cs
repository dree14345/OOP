using System;
using System.Collections.Generic;
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
            } else
            {
                return false;
            }
        }

		public void Bless()
		{
			Random rand = new Random();
			int index = rand.Next(angelNames.Length - 1);
			string randomAngel = angelNames[index];
			MessageBox.Show($"You have been blessed by: {randomAngel}", "Blessed", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		public void Protect()
        {
            Random rand = new Random();
            int index = rand.Next(angelNames.Length - 1);
            string randomAngel = angelNames[index];
			MessageBox.Show($"You have been protected by: {randomAngel}", "Blessed", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

        public void Heal()
        {
            Random rand = new Random();
            int index = rand.Next(angelNames.Length - 1);
            string randomAngel = angelNames[index];
			MessageBox.Show($"You have been healed by: {randomAngel}", "Blessed", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

        
    }
}
