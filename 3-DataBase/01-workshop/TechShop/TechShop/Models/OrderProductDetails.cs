using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Web.Models
{
    public class OrderProductDetails
    {
        public int ProductId { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }

    }
}
