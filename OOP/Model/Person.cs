using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    public class Person
    {
        private String FirstName, MiddleName, LastName;

        public String setFirstName
        {
            set { FirstName = value; }
        }

        public String setMiddleName
        {
            set { MiddleName = value; }
        }

        public String setLastName
        {
            set { LastName = value; }
        }

        public String getFirstName
        {
            get { return FirstName; }
        }

        public String getMiddleName
        {
            get { return MiddleName; }
        }

        public String getLastName
        {
            get { return LastName; }
        }

        public String getPerson
        {
            get { return "Hello I am " + FirstName[0].ToString().ToUpperInvariant() + String.Join("", FirstName.Skip(1)) + " " + MiddleName[0].ToString().ToUpperInvariant() + ". " + LastName[0].ToString().ToUpperInvariant() + String.Join("", LastName.Skip(1)) + " \nWelcome to OOP: "; }

        }
    }
}
