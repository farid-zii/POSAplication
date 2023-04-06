using Microsoft.EntityFrameworkCore;
using POSAplication.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSAplication.FrontEnd.DAL
{
    public class CustomersDAL
    {
        private ApplicationDbContext _dbContext;

        public CustomersDAL()
        {
            _dbContext = new ApplicationDbContext();
        }

        public IEnumerable<Customer> GetAll()
        {
            var results = _dbContext.Customers.ToList();

            return results;
        }

        public int Insert(Customer customer)
        {
            try
            {
                _dbContext.Customers.Add(customer);
                return _dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }

        public Customer GetByID(int customerId)
        {
            var result = _dbContext.Customers.Where(b => b.CustomerId == customerId).FirstOrDefault();
            if (result == null)
                throw new Exception($"Barang dengan kode {customerId} tidak Ditemukan");
            return result;
        }

        public int Update(Customer customer)
        {
            try
            {
                var updateBarang = GetByID(customer.CustomerId);

                updateBarang.Nama = customer.Nama;
                updateBarang.Alamat = customer.Alamat;
                updateBarang.Telp = customer.Telp;
                updateBarang.TanggalJoin = customer.TanggalJoin;

                var result = _dbContext.SaveChanges();
                return result;
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                throw new Exception(dbEx.Message);
            }

        }
        public int Delete(int customerId)
        {
            try
            {
                var deleteCustomer = GetByID(customerId);
                _dbContext.Customers.Remove(deleteCustomer);
                var reslut = _dbContext.SaveChanges();
                return reslut;
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }

        public IEnumerable<Customer> ByAlamat()
        {
            var results = _dbContext.Customers.OrderBy(b => b.Alamat).ToList();

            return results;
        }

        public IEnumerable<Customer> ByNama()
        {
            var results = _dbContext.Customers.OrderBy(b => b.Nama).ToList();

            return results;
        }

    }
}
