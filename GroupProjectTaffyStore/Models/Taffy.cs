using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProjectTaffyStore.Models
{
    [Table("Taffies")]
    public class Taffy
    {
        public int ID { get; set; }
        public string Flavor { get; set; }
        public int Size { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerID { get; set; }
    }
}