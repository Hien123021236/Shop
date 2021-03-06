using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public Production Production { get; set; }
        public string Color { get; set; }

        public Dictionary<string, string> Images { get; set; }
     
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        public int? BasePrice { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, int.MaxValue)]

        public int? Price { get; set; }

        public int? Quantity { get; set; }
    }
}