using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public Customer Customer { get; set; }
        public Promotion Promotion { get; set; }
        public ConsigneeInformation ConsigneeInformation { get; set; }
        public Payment Payment { get; set; }
        public Status Status { get; set; }
        public ICollection<BillItem> Items { get; set; }
    }
}