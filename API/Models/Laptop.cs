using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    [Table("Laptops")]
    public class Laptop : Product
    {
        [Column("CPU", TypeName = "nvarchar")]
        public string CPU { get; set; }

        [Column("RAM ", TypeName = "nvarchar")]
        public string RAM { get; set; }

        [Column("Graphics", TypeName = "nvarchar")]
        public string Graphics { get; set; }

        [Column("Screen", TypeName = "nvarchar")]
        public string Screen { get; set; }

        [Column("Storage", TypeName = "nvarchar")]
        public string Storage { get; set; }

        [Column("Camera", TypeName = "nvarchar")]
        public string Camera { get; set; }

        [Column("Weight", TypeName = "nvarchar")]
        public string Weight { get; set; }

        [Column("Battery", TypeName = "nvarchar")]
        public string Battery { get; set; }

        [Column("Audio", TypeName = "nvarchar")]
        public string Audio { get; set; }

        [Column("CardReader", TypeName = "nvarchar")]
        public string CardReader { get; set; }

        [Column("OS", TypeName = "nvarchar")]
        public string OS { get; set; }
    }
}