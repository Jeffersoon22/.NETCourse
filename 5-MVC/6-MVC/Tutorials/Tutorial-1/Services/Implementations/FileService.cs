using System.Collections.Generic;
using System.IO;
using System.Text;
using Tutorial_1.Model;

namespace Tutorial_1.Services
{
    public class FileService : IFileService
    {
        public void SaveToFile(List<Contact> contacts)
        {
            var sBuilder = new StringBuilder();

            foreach (var contact in contacts)
            {
                sBuilder.AppendFormat("Name: {0}, Phone: {1}, Position name: {2}, Salary: {3} \n", 
                    contact.Name,
                    contact.Phone,
                    contact.Position.Name,
                    contact.Position.Salary
                    );
            }

            File.WriteAllText("Contacts.txt", sBuilder.ToString());
        }
    }
}
