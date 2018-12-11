using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectTaffyStore.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int TaffyID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}