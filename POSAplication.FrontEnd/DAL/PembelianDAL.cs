using POSAplication.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSAplication.FrontEnd.DAL
{
    public class PembelianDAL
    {
        private readonly ApplicationDbContext _dbcontext;
        public PembelianDAL()
        {
            _dbcontext = new ApplicationDbContext();
        }
        #region update
        public void UpdateNota(string noNota,DateTime tanggalBeli,int supplierId)
        {
            //Cari No Nota yang akan Di Update
            var editNota = _dbcontext.NotaBelis.FirstOrDefault(n => n.NoNotaBeli == noNota);
            if (editNota!=null)
            {
                editNota.SupplierId = supplierId;
                editNota.TanggalBeli = tanggalBeli;
                _dbcontext.SaveChanges();
            }
            else
            {
                throw new Exception($"Data Nota beli {noNota} tidak ditemukan");
            }
        }
        #endregion

        #region generate
        public string GenerateNoNotaBeli(DateTime tanggalBeli, int kodeSupplier)
         {
             var lastNota = _dbcontext.NotaBelis.OrderByDescending(n => n.NoNotaBeli).FirstOrDefault();
             int nomor = 1;
             string nonota = string.Empty;
             if (lastNota == null)
             {
                 //Pertama Kali, Belum Ada Nota
                  nonota = "NB0001";
             }
             else
             {
                nomor = Convert.ToInt32(lastNota.NoNotaBeli.Substring(2, 4));
                 nomor++;
                 nonota = $"NB{nomor.ToString().PadLeft(4, '0')}";
             }

             try
             {
                 var newNota = new NotaBeli
                 {
                     NoNotaBeli = nonota,
                     TanggalBeli = tanggalBeli,
                     SupplierId = kodeSupplier
                 };
                 _dbcontext.NotaBelis.Add(newNota);
                 _dbcontext.SaveChanges();
                 return nonota;

             }
             catch (Exception ex)
             {

                 throw new Exception($"Error: {ex.InnerException.Message}");
             }
         }
        #endregion
    }
}
