using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
namespace Tutorials
{
    public class BinarySerializer<T> : ISerializer<T>
    {
        private const string FileName = "holiday.dat";
        private IFormatter formatter;
        public BinarySerializer()
        {
            formatter = new BinaryFormatter();
        }
        public void Serialize(T instance)
        {
            using (FileStream s = File.Create(FileName))
            {
                formatter.Serialize(s, instance);
            }
            Console.WriteLine("Object was serialized in holiday.dat");
        }
        public T Deserialize()
        {
            using (FileStream s = File.OpenRead(FileName))
            {
                T data = (T)formatter.Deserialize(s);
                Console.WriteLine("Object was deserialized from holiday.dat");
                return data;
            }
        }
    }
}