using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class Contact
    {
        public List<Address> address;
        public List<string> contactnumbers;
        public List<string> emailAds;
        public string name;

        public Contact()
        {
            address = new List<Address>();
            contactnumbers = new List<string>();
            emailAds = new List<string>();
        }
    }
}
