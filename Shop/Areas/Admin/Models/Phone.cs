using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Areas.Admin.Models
{
    public class Phone
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string Production { get; set; }

        public string Color { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? BasePrice { get; set; }

        public int? Price { get; set; }

        public int? Quantity { get; set; }
    }
}