using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace POSAplication.FrontEnd.Models
{
    public partial class Customer
    {
        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [StringLength(50)]
        public string Nama { get; set; } = null!;
        [StringLength(50)]
        public string? Alamat { get; set; }
        [StringLength(50)]
        public string? Telp { get; set; }
        [Column(TypeName = "date")]
        public DateTime TanggalJoin { get; set; }
    }
}
