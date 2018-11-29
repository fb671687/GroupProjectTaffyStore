using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectTaffyStore.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
    }
}