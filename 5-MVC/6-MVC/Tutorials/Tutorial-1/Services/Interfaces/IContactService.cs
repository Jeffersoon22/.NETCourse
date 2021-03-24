using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_1.Model;

namespace Tutorial_1.Services
{
    public interface IContactService
    {
        IEnumerable<Contact> GetContacts();

        void AddContact(Contact contact);
    }
}
