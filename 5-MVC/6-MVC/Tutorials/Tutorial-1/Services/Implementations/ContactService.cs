using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_1.Model;

namespace Tutorial_1.Services
{
    public class ContactService : IContactService
    {
        private List<Contact> contacts = new List<Contact> {
            new Contact {Name = "Sergii", Phone = "123456789" },
            new Contact {Name = "Max", Phone = "31134" },
            new Contact {Name = "Andrii", Phone = "734534534" },
        };

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public IEnumerable<Contact> GetContacts()
        {
            return contacts;
        }
    }
}
