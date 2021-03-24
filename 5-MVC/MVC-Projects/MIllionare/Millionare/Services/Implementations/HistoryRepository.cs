using Millionare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionare.Services.Implementations
{
    public class HistoryRepository : IRepository<History>
    {
        public List<History> _histories = new List<History>();
        public void Add(History hist)
        {
            _histories.Add(hist);
        }

        public IEnumerable<History> GetAll()
        {
            return _histories;
        }

        public void Update(History item)
        {
            
        }
    }
}
