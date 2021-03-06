using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Production
    {
        public int Id { get; set; }

        public string ProductionName { get; set; }

        public string Country { get; set; }

        //public ICollection<Product> Products { get; set; }
    }
}