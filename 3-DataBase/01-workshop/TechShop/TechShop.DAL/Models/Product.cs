using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechShop.DAL.Models
{
    public class Product
    {
        public Product()
        {
            OrderProducts = new List<OrderProduct>();
        }

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

        public List<OrderProduct> OrderProducts { get; set; }

    }
}
