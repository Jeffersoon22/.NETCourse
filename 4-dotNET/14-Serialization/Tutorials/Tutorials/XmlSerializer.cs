using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Tutorials
{
    public class XmlSerializer<T> : ISerializer<T>
    {
        private const string FileName = "holiday.xml";
        private XmlSerializer xs;

        public XmlSerializer()
        {
            xs = new XmlSerializer(typeof(T));
        }

        public void Serialize(T instance)
        {
            using(Stream s  = File.Create(FileName))
            {
                xs.Serialize(s, instance);
            }
            Console.WriteLine("Object was serialized in holiday.xml");
        }

        public T Deserialize()
        {
            using (Stream s = File.OpenRead(FileName))
            {
                T data = (T)xs.Deserialize(s);
                Console.WriteLine("Object was deserialized from holiday.xml");
                return data;
            }
        }
    }
}
