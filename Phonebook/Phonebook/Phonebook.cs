using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        public List<Contact> Contacts;

        public Phonebook()
        {
            Contacts = new List<Contact>();
        }

        public void AddContact(Contact x)
        {
            Contacts.Add(x);
        }

        public void DeleteContact(Contact x)
        {
            
        }

        public void EditContact(Contact x) { }
        public void SearchContact(Contact x) { }
    }
}
