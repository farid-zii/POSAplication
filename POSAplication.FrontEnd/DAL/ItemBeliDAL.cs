using Microsoft.EntityFrameworkCore;
using POSAplication.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSAplication.FrontEnd.DAL
{
    public class ItemBeliDAL
    {
        private ApplicationDbContext _dbContext;
        public ItemBeliDAL()
        {
            _dbContext = new ApplicationDbContext();
        }

        public IEnumerable<ViewModelPembelian> GetAll(string noNotaBeli)
        {
            //Join Table
            List<ViewModelPembelian> lstViewPembelian = new List<ViewModelPembelian>();
            var result = _dbContext.ItemBelis.Include(i => i.KodeBarangNavigation)
                .Where(i => i.NoNotaBeli == noNotaBeli).OrderBy(n => n.ItemBeliId);
            foreach (var item in result)
            {
                lstViewPembelian.Add(new ViewModelPembelian
                {
                    ItemBeliId = item.ItemBeliId,
                    NoNotaBeli = item.NoNotaBeli,
                    KodeBarang = item.KodeBarang,
                    NamaBarang = item.KodeBarangNavigation.NamaBarang,
                    HargaBeli = item.HargaBeli,
                    Jumlah = item.Jumlah,
                    Subtotal = item.HargaBeli*item.Jumlah
                });
            }
            return lstViewPembelian;

        }

        public void TambahItemBeli(ItemBeli itemBeli)
        {
            //Cek Apakah Item Barang Sudah Ada?
            var cekItem = _dbContext.ItemBelis.Where
                (i => i.NoNotaBeli == itemBeli.NoNotaBeli && i.KodeBarang == itemBeli.KodeBarang).FirstOrDefault();
            if (cekItem != null)
            {
                try
                {
                    //Ada barang yang sudah sama baru ditambahkan, Update Quantity
                    cekItem.Jumlah += itemBeli.Jumlah;
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception($"Error: {ex.Message}");
                }
                
            }
            else
            {
                //Menambahkan Itembeli
                try
                {
                    _dbContext.ItemBelis.Add(itemBeli);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception($"Error: {ex.Message}");
                }

            }
        }

        public void UpdateBarang(ItemBeli itemBeli)
        {
            try
            {
                var updateItem = _dbContext.ItemBelis.Where
                    (i => i.NoNotaBeli == itemBeli.NoNotaBeli && i.KodeBarang == itemBeli.KodeBarang).FirstOrDefault();
                if(updateItem != null)
                {
                    updateItem.Jumlah = itemBeli.Jumlah;
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

    }
}
