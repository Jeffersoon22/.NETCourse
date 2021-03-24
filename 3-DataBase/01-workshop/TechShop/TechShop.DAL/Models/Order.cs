using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechShop.DAL.Models
{
    public class Order
    {
        public Order()
        {
            Products = new List<Product>();
            OrderProducts = new List<OrderProduct>();
        }

        [Key]
        public int Id { get; set; } 

        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [Required]
        public string Zip { get; set; }
        
        [Required]
        public string State { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public bool IsShipped { get; set; }

        public List<Product> Products { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }
    }
}
