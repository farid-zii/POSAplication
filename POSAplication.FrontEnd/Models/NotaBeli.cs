﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace POSAplication.FrontEnd.Models
{
    [Table("NotaBeli")]
    public partial class NotaBeli
    {
        public NotaBeli()
        {
            ItemBelis = new HashSet<ItemBeli>();
        }

        [Key]
        [StringLength(10)]
        public string NoNotaBeli { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime TanggalBeli { get; set; }
        [Column("SupplierID")]
        public int SupplierId { get; set; }

        [ForeignKey("SupplierId")]
        [InverseProperty("NotaBelis")]
        public virtual Supplier Supplier { get; set; } = null!;
        [InverseProperty("NoNotaBeliNavigation")]
        public virtual ICollection<ItemBeli> ItemBelis { get; set; }
    }
}
