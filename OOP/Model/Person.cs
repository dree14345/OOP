using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace OOP.Model
{
    public class Person
    {
        private String FirstName, MiddleName, LastName, HealthCondition;

        private DateTime Birthdate;
        private int HeartRate, Temperature;

        
        private decimal weight;

        private Boolean IsBaby = false;
        private Boolean isHospitalize = false;
        
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


        public int getHeartRate
        {
            get { return HeartRate; }
        }

        public int setHeartRate
        {
            set { HeartRate = value; }
        }

        public int getTemperature
        {
            get { return Temperature; }
        }

        public int setTemperature
        {
            set { Temperature = value; }
        }

        public string getCondition
        {
            get { return HealthCondition; }
        }

        public Boolean setIsBaby
        {
            set { IsBaby = value; }
        }

        public Boolean getIsBaby
        {
            get { return IsBaby; }
        }

        public Boolean setIsHospitalized
        {
            set { isHospitalize = value; }
        }

        public Boolean getIsHospitalized
        {
            get { return isHospitalize; }
        }
        public DateTime SetBirthdate
        {
            set { Birthdate = value; }
        }

        public DateTime GetBirthdate
        {
            get { return Birthdate; }
        }
        public Decimal SetWeight
        {
            set { weight = value; }
        }
        public Decimal GetWeight
        {
            get { return weight; }
        }
        public String getPerson
        {
            get
            {
                return "Hello I am " +
                    FirstName[0].ToString().ToUpperInvariant() + String.Join("", FirstName.Skip(1)) + " " +
                    MiddleName[0].ToString().ToUpperInvariant() + ". " +
                    LastName[0].ToString().ToUpperInvariant() + String.Join("", LastName.Skip(1)); 
            }
        }


        public String getFullName
        {
            get
            {
                return FirstName[0].ToString().ToUpperInvariant() + String.Join("", FirstName.Skip(1)) + " " +
                       MiddleName[0].ToString().ToUpperInvariant() + ". " +
                       LastName[0].ToString().ToUpperInvariant() + String.Join("", LastName.Skip(1));
            }
        }

    }
}
