using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_XLII_Bojana_Backo
{
    class Employee
    {
        public string NameSurname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CardID { get; set; }
        public string JMBG { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Sector { get; set; }
        public string Location { get; set; }
        public string Manager { get; set; }

        public Employee()
        {
        }

        public Employee(string nameSurname, DateTime dateOfBirth, int cardID, string jMBG, string gender, string phone, string sector, string location, string manager)
        {
            NameSurname = nameSurname;
            DateOfBirth = dateOfBirth;
            CardID = cardID;
            JMBG = jMBG;
            Gender = gender;
            Phone = phone;
            Sector = sector;
            Location = location;
            Manager = manager;
        }
    }
}
