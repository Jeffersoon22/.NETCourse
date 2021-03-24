using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Tutorials
{
    public class JsonSerializer<T> : ISerializer<T>
    {
        private const string FileName = "holiday.json";
        public void Serialize(T instance)
        {
            var jsonString = JsonConvert.SerializeObject(instance);
            File.WriteAllText(FileName, jsonString);
        }

        public T Deserialize()
        {
            var jsonString = File.ReadAllText(FileName);
            var data = JsonConvert.DeserializeObject<T>(jsonString);
            return data;
        }
    }
}
