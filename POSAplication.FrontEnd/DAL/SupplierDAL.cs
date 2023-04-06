using Microsoft.EntityFrameworkCore;
using POSAplication.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSAplication.FrontEnd.DAL
{
    public class SupplierDAL
    {
        private ApplicationDbContext _dbContext;
        public SupplierDAL()
        {
            _dbContext = new ApplicationDbContext();
        }

        //Ambil Semua data
        public List<Supplier> GetAll()
        {
            var suppliers = _dbContext.Suppliers.OrderBy(s => s.Nama).ToList();
            return suppliers;
        }

        public List<Supplier> GetByNama(string Nama)
        {
            var result = _dbContext.Suppliers.Where(s => s.Nama.Contains(Nama))
                .OrderBy(s => s.Nama).ToList();
            return result;
        }

    }
}
