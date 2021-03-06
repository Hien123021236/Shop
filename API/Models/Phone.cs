using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    [Table("Phones")]
    public class Phone : Product
    {
        [Column("Network", TypeName ="nvarchar")]
        public Dictionary<string, string> Network { get; set; }

        [Column("Body", TypeName = "nvarchar")]
        public string Body { get; set; }

        [Column("Display", TypeName = "nvarchar")]
        public string Display { get; set; }

        [Column("Platfrom", TypeName = "nvarchar")]
        public string Platfrom { get; set; }

        [Column("Memory", TypeName = "nvarchar")]
        public string Memory { get; set; }

        [Column("MainCamera", TypeName = "nvarchar")]
        public string MainCamera { get; set; }

        [Column("SelfieCamera", TypeName = "nvarchar")]
        public string SelfieCamera { get; set; }

        [Column("Sound", TypeName = "nvarchar")]
        public string Sound { get; set; }

        [Column("Communications", TypeName = "nvarchar")]
        public string Communications { get; set; }

        [Column("Features", TypeName = "nvarchar")]
        public string Features { get; set; }

        [Column("Battery", TypeName = "nvarchar")]
        public string Battery { get; set; }

    }
}