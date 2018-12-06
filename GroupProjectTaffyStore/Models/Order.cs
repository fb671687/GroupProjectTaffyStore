using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectTaffyStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int CartID { get; set; }
        public decimal Total { get; set; }
    }
}