using System;
using System.ComponentModel.DataAnnotations;

namespace Planner.Models
{
    public class EventPlanning
    {
        public int Id { get; set; }

        public int _id { get; set; }

        [Required]
        [MinLength(2,ErrorMessage ="Event name must be more than 2 characters")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Event date must be inputed with valid date format")]
        public DateTime StartDateTime { get; set; }

        private DateTime _endDateTime;

        public string FuturePlans { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Author  must be inputed")]
        public string Author { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime? EndDateTime
        {
            get
            {
                return _endDateTime;
            }
            set
            {
                if (value.HasValue)
                {
                    _endDateTime = value.Value;
                }
                else
                {
                    _endDateTime = StartDateTime.AddHours(1.0);
                }
            }
        }


    }
}