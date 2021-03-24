using System.Collections.Generic;

namespace TechShop.Web.Models
{
    public class CreateOrderVm
    {
        public CreateOrderVm()
        {
            ProductDetails = new List<OrderProductDetails>();
        }

        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool IsShipped { get; set; }

        public List<OrderProductDetails> ProductDetails { get; set; }
    }
}
