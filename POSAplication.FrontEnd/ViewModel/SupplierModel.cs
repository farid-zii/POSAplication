using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSAplication.FrontEnd.ViewModel
{
    public class SupplierModel
    {
        public int SupplierId { get; set; }
        public string Nama { get; set; } = null!;
        public string? Alamat { get; set; }
        public string? Telp { get; set; }
    }
}
