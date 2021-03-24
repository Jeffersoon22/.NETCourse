using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GymManagementSystem.DAL.Models
{
    public class Member
    {
        

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Email { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public List<Payment> Payments { get; set; }
        public List<FitnessAndMembers> FitnessAndMembers { get; set; }


        public Member()
        {
            Payments = new List<Payment>();
            FitnessAndMembers = new List<FitnessAndMembers>();

        }

        

    }
}
