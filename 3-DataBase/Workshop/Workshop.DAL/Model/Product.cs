using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechShop.DAL.Model;

namespace Workshop.DAL.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]

        public decimal Price { get; set; }

        [Display(Name="Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
