using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practices.models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string HashedPassword { get; set; }

        public int InvalidLoginAttemptsAmount { get; set; }

        public bool IsBlocked { get; set; }

    }
}
