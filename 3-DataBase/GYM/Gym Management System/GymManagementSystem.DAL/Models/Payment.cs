using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GymManagementSystem.DAL.Models
{
    public class Payment
    {

        [Key]
        public int Id { get; set; }

        [Display(Name="Member")]
        public int MemberId { get; set; }

        public Member Member { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public decimal Amount { get; set; }

    }
}
