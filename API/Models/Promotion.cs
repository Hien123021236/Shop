using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public string PromotionName { get; set; }
        public string PromotionCode { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int? DiscountRate { get; set; }
    }
}