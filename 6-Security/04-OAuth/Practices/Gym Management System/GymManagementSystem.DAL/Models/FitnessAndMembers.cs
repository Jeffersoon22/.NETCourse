using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GymManagementSystem.DAL.Models
{
    public class FitnessAndMembers
    {
        public FitnessGroup FitnessGroup { get; set; }


        public Member Member { get; set; }


        [Display(Name ="Fitness Group")]
        public int FitId { get; set; }


        [Display(Name ="Member")]
        public int MemberId { get; set; }


       
    }
}
