using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int? Amount { get; set; }
        public DateTime? PaymentTime { get; set; }
    }
}