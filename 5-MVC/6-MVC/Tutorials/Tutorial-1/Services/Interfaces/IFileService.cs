using System.Collections.Generic;
using Tutorial_1.Model;

namespace Tutorial_1.Services
{
    public interface IFileService
    {
        void SaveToFile(List<Contact> contacts);

        
    }
}
