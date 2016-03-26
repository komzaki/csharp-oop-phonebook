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
            Contacts.Remove(x);
        }

        public void EditContact(Contact x) {

           

        }

        public void AddContactInfo(Contact x)
        {

            for (int i = 0; i < Contacts.Count; i++)
            {
                if (Contacts[i].name == x.name)
                {
                    if (x.emailAds[0] != null)
                    {
                        Contacts[i].emailAds.Add(x.emailAds[0]);
                    }
                    if(x.contactnumbers[0] != null)
                    {
                        Contacts[i].contactnumbers.Add(x.contactnumbers[0]);
                    }
                    if (x.address.Count > 0)
                    {
                        Contacts[i].address.Add(x.address[0]);
                    }

                }
            }

        }

        public void SearchContact(Contact x) { }
    }
}
