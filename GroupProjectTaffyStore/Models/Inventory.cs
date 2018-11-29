using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectTaffyStore.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Flavor { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int CurrentStock { get; set; }
    }
}