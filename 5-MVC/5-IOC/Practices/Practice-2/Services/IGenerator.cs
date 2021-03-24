using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_2.Services
{
    public interface IGenerator
    {
        int GeneratePositiveIntegerNumber();
        int GenerateNegativeIntegerNumber();
        string GenerateString(int lenght);
    }
}
