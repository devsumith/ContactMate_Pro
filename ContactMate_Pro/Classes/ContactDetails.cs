using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactMate_Pro
{
    public class ContactDetails
    {
        // PROPERTIES FOR OVERVIEW INFORMATION : ESSENTIAL TO BE FILLED
        public string Nickname { get; set; }
        public string Relationship { get; set; }
        public string ContactNumbers { get; set; }
        public string GmailAddresses {  get; set; }

        // PROPERTIES FOR PERSONAL INFORMATION
        public string LastName { get; set; } 
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string ExtensionName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Birthday { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Barangay { get; set; }
        public string City { get; set; }
        public string Province { get; set; }


    }
}
