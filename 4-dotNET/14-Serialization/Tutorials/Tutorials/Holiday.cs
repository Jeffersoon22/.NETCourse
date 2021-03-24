using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Tutorials
{
    [Serializable]
    public class Holiday
    {
        public Holiday()
        {

        }

        public Holiday(DateTime date, string designation, string note, bool isDayOff = default)
        {
            Date = date;
            Designation = designation;
            IsDayOff = isDayOff;
            Note = note;
        }

        public DateTime Date { get; set; }
        public string Designation { get; set; }
        public bool IsDayOff { get; set; }
        [XmlIgnore]
        public string Note { get; set; }

        public override string ToString()
        {
            return $"Date: {Date} \nDesignation: {Designation} \nDay off: {IsDayOff}";
        }
    }
}
