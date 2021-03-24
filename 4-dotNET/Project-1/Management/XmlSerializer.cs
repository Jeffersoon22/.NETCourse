using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Management
{
    public class XmlSerializer<T>
    {
        private XmlSerializer xmlsrlz;

        public XmlSerializer()
        {
            xmlsrlz = new XmlSerializer(typeof(T));
        }

        public string Serialize(T instance)
        {
            using (StringWriter str=new StringWriter())
            {
                xmlsrlz.Serialize(str, instance);
                return str.ToString();
            }
        }

        public T Deserialize(string input)
        {
            T data;
            
                using (StringReader strreader = new StringReader(input))
                {

                    data = (T)xmlsrlz.Deserialize(strreader);
                    return data;
                }
            

        }
    }
}
