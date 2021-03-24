using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tutorials
{
    class Program
    {
        private const string FileName = "holiday.dat";
        static void Main(string[] args)
        {
            var holiday = new Holiday(DateTime.Now.AddDays(2), "Saturday", "I like Saturdays");
            Console.WriteLine(holiday);

            Console.WriteLine();

            var binarySerializer = new BinarySerializer<Holiday>();
            binarySerializer.Serialize(holiday);

            var deserializedHoliday = binarySerializer.Deserialize();
            Console.WriteLine();
            Console.WriteLine(deserializedHoliday);
            Console.WriteLine();
            Console.WriteLine();

            var xmlHoliday = new Holiday(DateTime.Now.AddDays(3), "Sunday", "Sunday is chill");
            Console.WriteLine(xmlHoliday);

            Console.WriteLine();

            var xmlSerializer = new XmlSerializer<Holiday>();
            xmlSerializer.Serialize(xmlHoliday);
            var deserializedXmlHoliday = xmlSerializer.Deserialize();

            Console.WriteLine();
            Console.WriteLine(deserializedXmlHoliday);
            Console.WriteLine();
            Console.WriteLine();

            var jsonHoliday = new Holiday(DateTime.Now.AddDays(7), "Next week", "Json holiday");
            Console.WriteLine(jsonHoliday);

            Console.WriteLine();

            var jsonSerializer = new JsonSerializer<Holiday>();
            jsonSerializer.Serialize(jsonHoliday);
            var deserializedJsonHoliday = jsonSerializer.Deserialize();

            Console.WriteLine();
            Console.WriteLine(deserializedJsonHoliday);
            Console.ReadKey();
        }
    }
}
