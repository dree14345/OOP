using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Model
{
    public class Angel
    {



        public Boolean authorizeDischarge(String name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                MessageBox.Show($"You are now discharged with authorization from {name}", "Discharged Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } else
            {
                return false;
            }
        }
        

    }
}
