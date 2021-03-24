using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    interface ISerializer<T>
    {
        void Serialize(T instance);
        T Deserialize();
    }
}
