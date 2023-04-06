using POSAplication.FrontEnd.DAL;
using POSAplication.FrontEnd.Models;
using POSAplication.FrontEnd.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAplication.FrontEnd
{
    public partial class FormSupplier : Form
    {
        #region Singleton
        private static FormSupplier _instance;
        public static FormSupplier Instance()
        {
            if (_instance == null)
                _instance = new FormSupplier();
            return _instance;
        }
        #endregion


        private BindingSource bs;
        private SupplierDAL _supplierDAL;
        private PembelianDAL _pembelianDAL;
        public FormSupplier()
        {
            InitializeComponent();
            _supplierDAL = new SupplierDAL();
            _pembelianDAL = new PembelianDAL();
            bs = new BindingSource(); 
        }

        private List<SupplierModel> MappingSupplier(List<Supplier> lstsuppliers)
        {
            List<SupplierModel> supplierModels = new List<SupplierModel>();
            //foreach (var sup in _supplierDAL.GetAll())
            foreach (var sup in lstsuppliers)
            {
                supplierModels.Add(new SupplierModel
                {
                    SupplierId = sup.SupplierID,
                    Nama = sup.Nama,
                    Alamat = sup.Alamat,
                    Telp = sup.Telp
                });
            }
            return supplierModels;
        }

        //Method untuk mengisi data Barang
        private void IsiDataSupplier()
        {
            try
            {
                var result = MappingSupplier(_supplierDAL.GetAll());
                bs.DataSource = result;
                //bs.DataSource = _supplierDAL.GetAll();
                dgvSup.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchData(String nama)
        {
            try
            {
                bs.Clear();
                var result = MappingSupplier(_supplierDAL.GetByNama(nama));
                bs.DataSource = result;
                dgvSup.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            IsiDataSupplier();
        }

        private void txtNamaSup_TextChanged(object sender, EventArgs e)
        {
            if(txtNamaSup.Text.Length >= 2)
            {
                SearchData(txtNamaSup.Text);
            }
            else if (txtNamaSup.Text.Length == 0)
            {
                IsiDataSupplier();
            }
        }

        private void dgvSup_DoubleClick(object sender, EventArgs e)
        {
            SupplierModel curSup = (SupplierModel)bs.Current;
            //MessageBox.Show(curSup.SupplierID.ToString());
            FormPembelian.Instance().TxtKodeSupp.Text = curSup.SupplierId.ToString();
            FormPembelian.Instance().TxtNama.Text = curSup.Nama.ToString();
            FormPembelian.Instance().TxtAlamat.Text = curSup.Alamat.ToString();
            FormPembelian.Instance().TxtTelp.Text = curSup.Telp.ToString();

            //Edit Nonota
            _pembelianDAL.UpdateNota(FormPembelian.Instance().TxtNotaBeli.Text,
                FormPembelian.Instance().DtTanggal.Value, 
                curSup.SupplierId);

            this.Hide();
        }
    }
}
