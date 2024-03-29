﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace POSAplication.FrontEnd.Models
{
    [Table("Barang")]
    public partial class Barang
    {
        public Barang()
        {
            ItemBelis = new HashSet<ItemBeli>();
        }

        [Key]
        [StringLength(5)]
        public string KodeBarang { get; set; } = null!;
        [StringLength(50)]
        public string NamaBarang { get; set; } = null!;
        [Column(TypeName = "decimal(18, 0)")]
        public decimal HargaBeli { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal HargaJual { get; set; }
        public int Stok { get; set; }
        [Column(TypeName = "date")]
        public DateTime TanggalBeli { get; set; }
        public string? Keterangan { get; set; }

        [InverseProperty("KodeBarangNavigation")]
        public virtual ICollection<ItemBeli> ItemBelis { get; set; }
    }
}
