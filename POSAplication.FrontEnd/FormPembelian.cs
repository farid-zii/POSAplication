using POSAplication.FrontEnd.DAL;
using POSAplication.FrontEnd.Models;
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
    public partial class FormPembelian : Form
    {

        #region Singleton
        private static FormPembelian _instance;
        public static FormPembelian Instance()
        {
            if (_instance == null)
                _instance = new FormPembelian();
            return _instance;
        }
        #endregion


        public TextBox TxtKodeSupp
        {
            get { return TxtKodeSup; }
            set { TxtKodeSup = value  ; }
        }
        public TextBox TxtNama
        {
            get { return txtNamaSup; }
            set { txtNamaSup = value; }
        }
        public TextBox TxtAlamat
        {
            get { return txtAlamat; }
            set { txtAlamat = value; }
        }
        public TextBox TxtTelp
        {
            get { return txtTelp; }
            set { txtTelp = value; }
        }
        public DateTimePicker DtTanggal
        {
            get { return dtNota; }
            set { dtNota = value; }
        }
        public TextBox TxtNotaBeli
        {
            get { return txtNotaBeli; }
            set { txtNotaBeli = value; }
        }
        public TextBox TxtKodeBarang
        {
            get { return txtKodeBarang; }
            set { txtKodeBarang = value; }
        }
        public TextBox TxtNamaBarang
        {
            get { return txtNamaBarang; }
            set { txtNamaBarang = value; }
        }
        public TextBox TxtQty
        {
            get { return txtQty; }
            set { txtQty = value; }
        }
        public TextBox TxtHarga
        {
            get { return txtHarga; }
            set { txtHarga = value; }
        }
        public TextBox TxtSubTotal
        {
            get { return txtSubtotal; }
            set { txtSubtotal = value; }
        }


        #region Binding Tambah Data
        private void TambahBinding()
        {
            txtKodeBarang.DataBindings.Add("Text", bs, "KodeBarang");
            txtNamaBarang.DataBindings.Add("Text", bs, "NamaBarang");
            txtHarga.DataBindings.Add("Text", bs, "HargaBeli");
            txtHarga.DataBindings[0].FormattingEnabled = true;
            txtHarga.DataBindings[0].FormatString = "N0";
            txtQty.DataBindings.Add("Text", bs, "Jumlah");
            txtSubtotal.DataBindings.Add("Text", bs, "Subtotal");
            txtSubtotal.DataBindings[0].FormattingEnabled = true;
            txtSubtotal.DataBindings[0].FormatString = "N0";

        }

        private void HapusBinding()
        {
            txtKodeBarang.DataBindings.Clear();
            txtNamaBarang.DataBindings.Clear();
            txtHarga.DataBindings.Clear();
            txtQty.DataBindings.Clear();
        }

        private void IsiData()
        {
            bs.DataSource = _itemBeliDAL.GetAll(txtNotaBeli.Text);
            dgvPembelian.DataSource = bs;
        }

        #endregion

        private PembelianDAL _pembelianDAL;
        private ItemBeliDAL _itemBeliDAL;
        private BindingSource bs;
        private bool isTambah = false;
        public FormPembelian()
        {
            InitializeComponent();
            _pembelianDAL = new PembelianDAL();
            _itemBeliDAL = new ItemBeliDAL();
            bs = new BindingSource();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSupplier.Instance().Show();
        }

        private void FormPembelian_Load(object sender, EventArgs e)
        {
            dtNota.Value = DateTime.Now;
           txtNotaBeli.Text = _pembelianDAL.GenerateNoNotaBeli(dtNota.Value, 1);
        }

        private void txtKodeBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                HapusBinding();
                isTambah = true;
                FormBarang.Instance().Show();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double subtotal = Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtHarga.Text);
                txtSubtotal.Text = String.Empty;
                txtSubtotal.Text = subtotal.ToString("N0");
                txtSubtotal.Focus();

            }
        }

        private void txtSubtotal_KeyDown(object sender, KeyEventArgs e)
        {

            var newItemBeli = new ItemBeli
            {
                NoNotaBeli = txtNotaBeli.Text,
                KodeBarang = txtKodeBarang.Text,
                HargaBeli = Convert.ToDecimal(txtHarga.Text),
                Jumlah = Convert.ToInt32(txtQty.Text)
            };

            if (e.KeyCode == Keys.Enter)
            {
                HapusBinding();
        
                if (isTambah)
                {
                    try
                    {
                        _itemBeliDAL.TambahItemBeli(newItemBeli);
                        IsiData();
                        TambahBinding();
                        isTambah = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error");
                    }
                }
                else
                {
                    //Update Barang

                }

            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            HapusBinding();
        }
    }
}
