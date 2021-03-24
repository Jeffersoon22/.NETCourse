using System;
using System.Collections.Generic;
using System.Text;
namespace Tutorials
{
    interface ISerialize<T>
    {
        void Serialize(T instance);
        T Deserialize();
    }
}