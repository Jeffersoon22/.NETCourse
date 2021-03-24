using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GymManagementSystem.DAL.Models
{
    public class FitnessGroup
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


        [Required]
        [DataType(DataType.Time)]
        [Display(Name="Start Time")]
        public DateTime StartTime { get; set; }


        [Required]
        [DataType(DataType.Time)]
        [Display(Name="End Time")]
        public DateTime EndTime { get; set; }


        public List<FitnessAndMembers> FitnessAndMembers { get; set; }


        public FitnessGroup()
        {
            FitnessAndMembers = new List<FitnessAndMembers>();
        }

    }
}
